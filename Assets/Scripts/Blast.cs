using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{

    public float speedBullet = 20f;         // Vitesse (décimal) de la blastos
    public int damages = 10;            // Puissance (entier) de la blastos
    public Rigidbody2D rgbd2Bullet;

    // Start is called before the first frame update
    void Start()
    {
        rgbd2Bullet.velocity = transform.right * speedBullet;           // Contrainte sur les axes, l'origine et la finalité du tir  // right= (]->) // velocity==10 * 
    }



    // Update is called once per frame
    void Update()
    {
        damages = GameObject.FindWithTag("Player").GetComponent<Scooter>().bullet_damage;           // Chercher le script () ou se trouve les dégats et le detruire le GO 
        //Debug.Log(damages);                                                                       
        Destroy(this.gameObject,3f);            // Detruire le GO (Blast, prefab) dans la hierachie au bout de 3s 

    }
}

   



   