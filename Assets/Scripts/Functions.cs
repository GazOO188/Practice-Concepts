using System.Numerics;
using UnityEngine;

public class Functions : MonoBehaviour
{
    //THIS SCRIPT IS TO PRACTICE FUNCTIONS//
   
    
    //FLOAT VALUES FOR HEALTH//


    public float health = 100f;


    public float attackrange;
    
     


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //FUNCTION PRACTICE//

    //THIS FUNCTION IS USED TO CALCULATE THE NEW SCORE//
    int NewScore(int baseScore, int points)
    {
        
        int TotalScore = baseScore + points;

        return TotalScore;
  
  
  
    }


    //A FUNCTION FOR APPLYING DAMAGE BUFFS//


    float ApplyDamageBuff(float baseValue, float Multiplier)
    {
        
   
        float NewDamage = baseValue * (1 + Multiplier/100);
       
        return NewDamage;
        
   
   
   
    }


    //FUNCTION FOR TAKING DAMAGE//


    void TakeDamage(float damage)
    {
        
        health -= damage;

        health = Mathf.Clamp(health, 0, 100);
        
    
    
    
    }



   //FUNCTIION THAT APPLIES DIRECTION//



    UnityEngine.Vector3 GetDirection(UnityEngine.Vector3 Starting, UnityEngine.Vector3 Ending)
    {
     
     
        //GETS DIRECTION FROM ENDING TO STARTING//
        return(Ending - Starting).normalized;



         //CAN USE IT LIKE THIS//

        // VECTOR3 DIRECTION = GETDIRECTION(TRANSFORM.POSITION, TARGET.POSITION);

        // TRANSFROM.POSTION += DIRECTION * SPEED * TIME.DELTATIME;
    
    
    }


    //FUNCTION FOR ENEMY CHASE//


    UnityEngine.Vector3 ChasePlayer(UnityEngine.Vector3 PlayerPos, UnityEngine.Vector3 EnemyPos)
    {
        
        //THIS GETS THE DIRECTION VECTOR FROM ENEMY TO PLAYER//
        UnityEngine.Vector3 DirToPlayer = PlayerPos - EnemyPos;


        //GET THE SQUARE MAGNTIUDE OF THE VECTOR, WITHOUT DOING SQUARE ROOT//

        float LengthofDir = DirToPlayer.sqrMagnitude;



        //MULTIPLY ATTACKRANGE TWICE TO SQAURE IT AND COMPARE AGAINST LENGHTOFDIR//
        if(LengthofDir < attackrange * attackrange)
        {
            
            Debug.Log("In Range");


       
       
       
        }


        return DirToPlayer;



    
    
    

    }



    //FUNCTION THAT RETURNS DOT PRODUCT OF TWO VECTORS//


    float DetermineDotProduct(UnityEngine.Vector3 Direction, UnityEngine.Vector3 Forward)
    {
        


        //THIS RETURNS THE DOT PRODUCT BETWEEN DIRECTION AND FORWARD TO SEE HOW ALIGNED THE VECTORS ARE//
        
        return UnityEngine.Vector3.Dot(Direction, Forward);
   
   
   
    }




    //VOID FUNCTIONS//


    //HEALING FUNCTION//
    public void HealAmount(float Amount)
    {
        
        health += Amount;

        health = Mathf.Clamp(health, 0, 100);
   
   
   
   
    }


    //TAKE DAMAGE FUNCTION//

    public void TakeDamg(float amount)
    {
        
        health -= amount;

        health = Mathf.Clamp(health, 0, 100);
  
   
    }



    //FUNCTION FOR PERCENTS/APPLY BUFFS//

    public void ApplyBuff(float baseValue, float Percent)
    {
        
        health += baseValue * (1+ Percent/100f);
    
    
    
    
    }



    



}
