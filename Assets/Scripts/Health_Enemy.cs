using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Enemy : MonoBehaviour
{

    public int bullet_Damage;           // Recupere la var des dégats actuel (base+incrementation)
    public int maxHealth_Enemy = 100;
    public int currentHealth_Enemy;
    public Health_Bar healthBar_Enemy;
    public Slider enemySlider; 
   
    

   

    // Start is called before the first frame update
    void Start()
    {
        currentHealth_Enemy = maxHealth_Enemy;
    }

    // Update is called once per frame
    void Update()
    {
      
    }      
            
    void TakeDamage(int damage)
    {
        currentHealth_Enemy -= damage;
        healthBar_Enemy.SetHealth(currentHealth_Enemy);

    }

    

    void TakeDamage()
    {
        if(currentHealth_Enemy>0)
        {
            Debug.Log(currentHealth_Enemy);
            currentHealth_Enemy -= bullet_Damage;
        }
        
        else
            Destroy(this.gameObject);

        
    }

    void Heal_Bar_Enemy_Fade_Out()
    {   
        if(currentHealth_Enemy==0)
            GameObject.Find("Heal_Bar_Enemy").SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
    
        if(col.gameObject.tag == "Bullet")          // Si collision avec Tag "x"
        {
            Debug.Log(col.name);
            bullet_Damage = col.gameObject.GetComponent<Blast>().damages;
            TakeDamage();
            Destroy(col.gameObject);

            
        }

    }


}
