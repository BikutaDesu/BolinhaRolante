using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float speed = 5;
    private int score = 0;

    private Rigidbody rb;

    public Text txtScore;
    public Text txtGameOver;

    public GameObject itemParticle;

    // Start is called before the first frame update
    void Start()
    {
        txtGameOver.gameObject.SetActive(false);
        txtScore.text ="SCORE: " + score.ToString();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        rb.AddForce(moveDirection * speed);
    }

    void OnTriggerEnter(Collider other) {
        switch (other.tag)
        {
            case "Item":
                AddScore(10);
                Instantiate(itemParticle, other.transform.position, Quaternion.identity);
                Destroy(other.gameObject);
                break;
        }
    }

    void AddScore(int score){
        this.score+=score;
        txtScore.text = "SCORE: " + this.score.ToString(); 
        if(this.score >= 120){
            txtGameOver.gameObject.SetActive(true);
        }
    }
}
