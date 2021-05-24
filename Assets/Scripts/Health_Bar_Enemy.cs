using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Health_Bar_Enemy : MonoBehaviour
{

    public Slider enemySlider;

    public void SetMaxHealth(int health)
    {
        enemySlider.maxValue = health;
        enemySlider.value = health;
    }
    

    public void SetHealth(int health)
    {
        enemySlider.value = health;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

