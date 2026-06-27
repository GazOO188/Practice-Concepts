using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //THIS SCCRIPT IS FOR THE HEALTHBAR LOGIC//
    

    [Header("Info")]
    public float MaxHealth = 100f;
    public float CurrentHealth;


    [Header("Ui Info")]
    public Slider HealthSlider;



    [Header("Bools")]
    public bool CanDecrease = false;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        CurrentHealth = MaxHealth;

        HealthSlider.maxValue = MaxHealth;

        HealthSlider.value = CurrentHealth;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            DecreaseHealth(4f);

          
        }


        Debug.Log(CurrentHealth);
        
    }


    //FUNCTIONS TO DECREASE HEALTHBAR//


    private void DecreaseHealth(float DamageAmount)
    {
        
        CurrentHealth -= DamageAmount;

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
       
        HealthSlider.value = CurrentHealth;


    }



}
