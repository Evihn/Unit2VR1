using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    int number = 1;
    Rigidbody2D collider = null;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(number);
        Debug.Log(collider);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
