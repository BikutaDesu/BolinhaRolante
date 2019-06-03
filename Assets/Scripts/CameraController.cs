using UnityEngine;

public class CameraController : MonoBehaviour {
    
    public GameObject ballObject;
    private Vector3 startPosition;

    private void Start() {
        startPosition = transform.position - ballObject.transform.position;
    }

    private void Update() {
        transform.position = ballObject.transform.position + startPosition;
    }
}