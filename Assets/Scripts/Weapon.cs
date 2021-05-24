using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
   
    public Transform y_Bullet;
    public GameObject Blast;

    private Fire controls;
    
    //private Animator animator;
    
    

    private void OnEnable()
    {
        controls = new Fire();
        controls.Enable();

        controls.Bullet.Shoot.performed += ShootOnPerformed;
    }

    private void ShootOnPerformed(InputAction.CallbackContext obj)           // Produit une Blastos a chaque Input
    {
        Instantiate(Blast, y_Bullet.position, y_Bullet.rotation);           // (y_Bullet.position, y_Bullet.rotation) = force le transform a suivre le Joueur
    }                                                                       

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
