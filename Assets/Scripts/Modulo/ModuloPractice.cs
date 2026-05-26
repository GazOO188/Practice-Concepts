using System.Collections.Generic;
using UnityEngine;

public class ModuloPractice : MonoBehaviour
{
    //THIS SCRIPT IS FOR MODULO PRACTICE//



    //INT VARIABLES//
   
    public int KillCount;

    public int EnemyCount;

    public int WaveCount;

    public int Score;

    
    //FLOAT VARIABLES//

    public float Timer;

    public float Cooldown;



    //ARRAY OF ENEMIES//

    public GameObject[] Enemies;


    //DICTIONARY//

    public Dictionary<GameObject, int> EnemyHealth = new Dictionary<GameObject, int>();


    //LIST//

    public List<int> AllHealthValues = new List<int>(){5,6,9};


    //GAMEOBJECTS//

    public GameObject Enemy1, Enemy2;


    //BOOLEAN//

    public bool DamageApplied = false;


    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        //ADDING ELEMENTS INTO THE ARRAY//
       // Enemies[0] = Enemy1;

       // Enemies[1] = Enemy2;


        //ADDING ELEMENTS INTO THE DICTIONARY//

        EnemyHealth.Add(Enemy1, 90);





        
    }

    // Update is called once per frame
    void Update()
    {
        
        Cooldown -= Timer * Time.deltaTime;



        //MODULO PRACTICE//


        //FOR EVERY 5 SCORE POINTS PRINT THE MESSAGE BELOW//
        if(Score % 5 == 0)
        {
            
            //Debug.Log("Bonus Points");
        
        
        
        }


        //FOR LOOPS WITH MODULO//

        //EVERY 3 WAVES PLAY SPECIAL EVENT//

        for(int i = 1; i<= 10; i++)
        {
            
            if(i % 3 == 0)
            {
                
               // Debug.Log("Special Event");
            
            
            }
            
        
        
        }



        //MODULO WITH ARRAYS & FOR LOOPS//


        for(int i = 0; i<Enemies.Length; i++)
        {
       
            if(i % 3 == 0)
            {
                
                //EACH 3RD ENEMY IS AN ELITE ENEMY//
                //Debug.Log("Elite Enemy");
            
            
            
            }       
       
       
        }




        for(int i = 0; i<AllHealthValues.Count; i++)
        {
            
       
            //THIS SUBTRACTS RANDOM DAMAGE FROM THE HEALTH VALUES//
            AllHealthValues[i] -= Random.Range(5, 20);


            //IF ONE OF THE VALUES IS BELOW OR EQUAL TO 0, THEN REMOVE THE VALUE FROM THE LIST//
            if(AllHealthValues[i] <= 0)
            {
                
                AllHealthValues.RemoveAt(i);

               // Debug.Log("Remove Dead Enemy");
            
            
            
            }
       
       
       
       
       
        }
        
   
   
        //THIS GETS THE HEALTH VALU OF ENEMY 1//
        int EnemyHealthValue = EnemyHealth[Enemy1];


        //Debug.Log("Health value:" + EnemyHealthValue);



        if (!DamageApplied)
        {
            
        
   
        foreach(GameObject Enemy in EnemyHealth.Keys)
        {
            
           EnemyHealth[Enemy] -= 5;

           //BREAK STOPS THE LOOP BUT NOT VOID UPDATE THIS WILL RUN EVERY FRAME REGARDLESS//
           break;
      
      
        }

        //THIS ONLY APPLIES DAMAGE ONCE TO ONE OF THE VALUES//
        DamageApplied = true;
   
        }
   
    }




}

