using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
   
    public Transform y_Bullet;
    public GameObject Blast;

    private Fire controls;

    private void OnEnable()
    {
        controls = new Fire();
        controls.Enable();

        controls.Bullet.Shoot.performed += ShootOnPerformed;
        
    }

    private void ShootOnPerformed(InputAction.CallbackContext obj)
    {
        Instantiate(Blast, y_Bullet.position, y_Bullet.rotation);
    }

    



    // Update is called once per frame
    void Update()
    {
        
       





    }
}
