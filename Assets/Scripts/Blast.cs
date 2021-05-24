using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public float speedBullet = 20f;
    public int damages = 10;
    public Rigidbody2D rgbd2Bullet;



    


    // Start is called before the first frame update
    void Start()
    {
        rgbd2Bullet.velocity = transform.right * speedBullet;

        
    }



    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        damages = GameObject.FindWithTag("Player").GetComponent<Scooter>().bullet_damage;
        Debug.Log(damages);
        Destroy(this.gameObject,3f);  //s'autodetruit 

    }
}

   



   