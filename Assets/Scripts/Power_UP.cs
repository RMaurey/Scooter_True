using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_UP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)        
    {
        if(col.gameObject.tag == "Player" )         // Si GO avec tag Player touche le Collider alors ce GO disparait.
        {
            this.gameObject.SetActive(false);           // SetActive(bool) = permet de désactiver un GO
            //Debug.Log(col.name);
        }
    }
}
