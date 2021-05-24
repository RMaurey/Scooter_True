using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{

    Animation fadeOut;



    // Start is called before the first frame update
    void Start()
    {
        fadeOut = this.gameObject.GetComponent<Animation>();
        fadeOut.Play("FadeOut");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
