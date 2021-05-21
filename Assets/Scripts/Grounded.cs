using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    public float distanceGround;

    public bool isGrounded = false;



    // Start is called before the first frame update
    void Start()
    {
        distanceGround = GetComponent<Collider>().bounds.extents.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!Physics.Raycast(transform.position, -Vector2.up, distanceGround + 0.1f))
            isGrounded = false;
        
        else
        {
            isGrounded = true;
        }


    }
}
