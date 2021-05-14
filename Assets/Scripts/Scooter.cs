using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class Scooter : MonoBehaviour
{
    // VARIABLES UNITY //



    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;



    // PHYSIQUES //



    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;
    private Animator animator;


    //private bool canJump;
    //public bool isGrounded;




    // COMMANDES //




    private ControlScooter controls;

    private void OnEnable()
    {

        controls = new ControlScooter();
        controls.Enable();
        controls.Scooter.Jump.performed += JumpOnperformed;
        controls.Scooter.Lateral.performed += LateralOnperformed;
       

        controls.Scooter.Lateral.canceled += Lateralcanceled;
        

    }



    private void JumpOnperformed(InputAction.CallbackContext obj)
    { 
       rgdb2.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }


    private void LateralOnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        if (direction > 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
        
    private void Lateralcanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
    }
   




    // Start is called before the first frame update
    void Start()
    {
        rgdb2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        if (horizontalSpeed < maxSpeed)
        {
            rgdb2.AddForce(new Vector2(speed * direction, 0));
        }
    }











}
