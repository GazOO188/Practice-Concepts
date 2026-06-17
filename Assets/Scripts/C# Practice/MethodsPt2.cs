using UnityEngine;

public class MethodsPt2 : MonoBehaviour
{
    //THIS SCRIPT IS FOR METHODS PART 2//

    public int ShieldArmor;

    public int health = 20;

    public int Shield
    {

        get
        {
            

            return ShieldArmor;

        }


        set
        {
            
            ShieldArmor = value;



        }



    }


    public void TakeDamage(int Dmg)
    {
        
        health -= Dmg;


        Debug.Log(IsDead());
       
        IsDead();

        



    }

    int DamageTaken(int damage)
    {
        
        int AmountTaken = 0;


        if(damage < Shield)
        {
            
            Debug.Log("Shield Not destroyed");

            AmountTaken = 0;

        }


        else if(damage == Shield)
        {
            
           Debug.Log("Shield Not destroyed");

           AmountTaken = 0;



        }


        else if(damage > Shield)
        {
            
            Debug.Log("Shield Destroyed");


            AmountTaken = damage - Shield;




        }



        return AmountTaken;

    }



    public void Start()
    {
        

    ShieldArmor = 50; 


   // DamageTaken(30);  


     TakeDamage(20);




    }



    public bool IsDead()
    {
        
      return health <= 0;  



    }

   
}
