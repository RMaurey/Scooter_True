using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class Scooter : MonoBehaviour
{
    // Variables Unity //
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;



    // Physiques ////


    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;

    private bool canJump;
    public bool isGrounded;

    // Commande //

    private Controllers controls;














    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
