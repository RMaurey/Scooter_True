using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public float speedBullet = 20f;
    public Rigidbody2D rgbd2Bullet;




    // Start is called before the first frame update
    void Start()
    {
        rgbd2Bullet.velocity = transform.right * speedBullet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

   



   