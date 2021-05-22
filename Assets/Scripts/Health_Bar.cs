using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Health_Bar : MonoBehaviour
{

    public Slider scooterSlider;

    public void SetMaxHealth(int health)
    {
        scooterSlider.maxValue = health;
        scooterSlider.value = health;
    }
    

    public void SetHealth(int health)
    {
        scooterSlider.value = health;
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
