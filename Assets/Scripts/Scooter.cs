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
    [SerializeField] private Transform RaycastStartTransform;
    [SerializeField] private LayerMask Layer;

    
    
    




    // PHYSIQUES //



    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;
    private Animator animator;
    private CapsuleCollider2D capColl2D;
   






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
        if (Physics2D.Raycast(RaycastStartTransform.position,Vector2.down , 0.1f, Layer))   
            rgdb2.AddForce(jumpForce * transform.up, ForceMode2D.Impulse);


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

        animator.SetBool("Running", true);
    }

        
    private void Lateralcanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
        animator.SetBool("Running", false);
    }
   

    // Start is called before the first frame update
    void Start()
    {
        rgdb2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        capColl2D = GetComponent<CapsuleCollider2D>();

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
