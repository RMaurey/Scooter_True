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
    //[SerializeField] private Transform RaycastStartTransform;
    
    
    




    // PHYSIQUES //



    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;
    private Animator animator;

    private bool canJump = false;
    


    



    
     


    

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
       canJump = false;

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
   
        // Animator //

    
  



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

        //var hit = Physics2D.Raycast(RaycastStartTransform.position, new Vector2(0, -1), 0.01f);
        //Debug.DrawRay(transform.position, new Vector2(0, -1) * 0.001f);

        /*if (hit.collider != null)
        {
            canJump = true;
        }

        else 
        {
            canJump = false;
        }

        */
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        if (horizontalSpeed < maxSpeed)
            
            animator.SetBool("Run", true); // ne pas oublier de mettre un parametre en fonction de. Bool > True or false. Float valeur décimal ...
        
        //if (Input.);






    }


    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        if (horizontalSpeed < maxSpeed)
        {
            rgdb2.AddForce(new Vector2(speed * direction, 0));
        }

        
        var verticalSpeed = rgdb2.velocity.y;


      






    }











}
