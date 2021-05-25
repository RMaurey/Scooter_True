using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{   

    public GameObject shibakutensei;
    Animation FadeIn;
    SpriteRenderer m_SpriteRenderer;


    
    // Start is called before the first frame update
    void Start()
    {
        FadeIn = transform.GetChild(1).GetComponent<Animation>();
        //Debug.Log(FadeIn);
        m_SpriteRenderer = transform.GetChild(1).GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = new Color (0f, 0f, 0f, 0f);
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void Play()
    {
        StartCoroutine(start_Game());  
    }

    IEnumerator start_Game()
    {
        
        yield return new WaitForSeconds(1f);
        FadeIn.Play();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("lieu_Du_Meurtre");
        yield break;
    }









}





