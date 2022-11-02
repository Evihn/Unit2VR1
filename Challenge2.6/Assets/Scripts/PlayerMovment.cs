using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Vector2 xMove;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
      
        player = gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        transform.Translate(xMove * Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
        transform.localScale *= flip;
    }
}
