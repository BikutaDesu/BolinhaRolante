using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{



    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(15,45,30) * Time.deltaTime);    
    }
}
