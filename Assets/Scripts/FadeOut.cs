using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           // Obligatoire pour utiliser un Canvas (Text Mesh Pros, PM)


public class FadeOut : MonoBehaviour
{

    Animation fadeOut;          // Declartion de la var de l'Animation dans le script et nommé 

    // Start is called before the first frame update
    void Start()
    {
        fadeOut = this.gameObject.GetComponent<Animation>();             // Appele le composent Animation dans Unity a qui ce GO fait reference excluvisement (this.)
        fadeOut.Play("FadeOut");            // Lancement de l'animation FadeOut

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
