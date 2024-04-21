using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveSpeed = 3.0f;
        Vector3 v = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -moveSpeed;
        }
        else
        {
            v.x = 0;
        }
        rb.velocity = v;
    }


    void Update()
    {
        float jumpSpeed = 10.0f;
        Vector3 v = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }

        rb.velocity = v;
    }

}
