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


    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;
    private Animator animator;
    private CapsuleCollider2D capColl2D;
    //private float timer;
    private bool can_move;
    public int bullet_damage = 10;  
    public GameObject up_Blast;


   
            // COMMANDES //


    private ControlScooter controls;

    private void OnEnable()
    {
            // PERFORMED //

        if(can_move)
        {     
        controls = new ControlScooter();
        controls.Enable();
        controls.Scooter.Jump.performed += JumpOnperformed;
        controls.Scooter.Lateral.performed += LateralOnperformed;
      
            // CANCELED //

        controls.Scooter.Lateral.canceled += Lateralcanceled;
        }
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
    }

        
    private void Lateralcanceled(InputAction.CallbackContext obj)
    {
        direction = 0;    
    }

    public void Up_damage()   // Incremente de x la valeur des degats
    {
       bullet_damage += 10; 
       //Debug.Log(bullet_damage); 
    }
    

    void OnTriggerEnter2D(Collider2D col)       // Declenche l'augmentation des degats au contact du collider
    {
        if(col.gameObject.tag == "Power_Up")
        {
            Up_damage();
            //Debug.Log(col.name);
        }
    }





    // Start is called before the first frame update
    void Start()
    {
        rgdb2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        capColl2D = GetComponent<CapsuleCollider2D>();
        can_move = false;
        StartCoroutine(timer_fadeOut());
        up_Blast.GetComponent<Blast>().damages = bullet_damage;
    }


    void EnableController()   // Apres les secondes du FadeOut, les touches sont dispos. Cela evite de deplacer le Joueur lors d'un chargement.
    {                         // Et de se retrouver dans un trou possible lors d'une auto save, proche de celui-ci. Si le cas se presente.  
        if(can_move)
        OnEnable();
    }


    IEnumerator timer_fadeOut()                    // Coroutine permettant au Canvas de disparaitre progressivement, de laisser place a la scene principal
    {                                              // 
        yield return new WaitForSeconds(2.5f);
        can_move = true;
        EnableController();
        yield break;
    }


    // Update is called once per frame
    void Update()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        animator.SetFloat("Running", Mathf.Abs(horizontalSpeed));  
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
