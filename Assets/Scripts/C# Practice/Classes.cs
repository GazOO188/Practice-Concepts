using System;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Classes : MonoBehaviour
{
    
    //THIS SCRIPT IS FOR CLASSES//
    public enum WeaponStates
    {
        AutoRifle,

        SubmachineGun,

        Shotgun,

        Glaived,  
   
   
   
    }

    //THIS ENUMS IS FOR PLAYER STATS//

    public enum AllPlayerStats
    {
        
        Health,

        Melee,

        Grenade,

        Super,

        Class,

        Weapon,



    }
    //THIS IS A PLAYER CLASS//
    public class Player
    {
        
        public int health = 50;
        
        public int Maxhealth = 100;

        public int score = 0;
        
        public float speed = 20f;

        public float Damage = 10f;



        //THIS FUNCTION IS FOR TAKING DAMAGE//
        public void TakeDamage(int amount)
        {
            
        
            health -= amount;

            //THIS LINE CLAMPS THE HEALTH SO IT DOSENT GO BELOW 0 INTO NEGATIVE VALUES//
            health = Mathf.Clamp(health, 0, Maxhealth);



            if(health <= 0)
            {
                
                health = 0;


                Debug.Log("dead");


            }


        
        }


        //THIS FUNCTION IS FOR HEALING//


        public void HealAmount(int amount)
        {
            
            health += amount;

            health = Mathf.Clamp(health, 0, Maxhealth);
        
        
        }


        //THIS FUNCTION IS FOR ADDING SCORE//


        public void AddScore(int ScoreAmount)
        {
            
            score += ScoreAmount;

            score = Mathf.Clamp(score, 0, 100);
       
       
       
       
        }


        //THIS FUNCTION IS FOR APPLYING DAMAGE BUFF//

        public void ApplyDamageBuff(float Percent)
        {
            
            
            Damage = Damage * (1+ Percent/100);
        
        
        }


        public void Die()
        {
            





        }




   
    }


    public class Weapons
    {
        
        //THIS REPRESENTS THE TYPE OF WEAPON//
        public WeaponStates WeaponType;

        //AMMO CAPACITY HOW MUCH MAGS//
        public int ammoCapacity = 100;

        //BULLETS IN EACH MAG//
        public int MagazineSize = 10;

        //FIRE RATE OF WEAPONS//
        public float RoundsperMinutes = 0.5f;

        //THE NEXT TIME THE PLAYER CAN SHOOT// 
        public float nextTimetoShoot;


   
        public void Shoot()
        {
            
            if(MagazineSize > 0)
            {
                
                MagazineSize--;

                Debug.Log("Can Shoot");
            
            
            }



            else
            {
                
                Debug.Log("Reload");
            
            
            }
        

            //FOR EVERY 3 BULLETS LOAD AN EXPLOSIVE BULLET//
            
            if(MagazineSize % 3 == 0)
            {
                
                Debug.Log("Load a explosive bullet");
            
            
            }
        
        
        }
   
   


    }


    //ENEMY CLASS//

    public class Enemy
    {
        
    
         public int health;

         public float speed;

         public int damageDealt;


         public float AttackRadius;



        
        
         public Rigidbody rb;




        public void ChasePlayer(Vector3 Position, Vector3 PlayerPos)
        {

            //GETS DIRECTION FROM ENEMY TO PLAYER//
            Vector3 DirtoPlayer = (PlayerPos - Position);


            //GETS LENGTH OF THE DIRECTION//
            float LengthofDirtoPlayer = DirtoPlayer.sqrMagnitude;


            //THIS COMPARES THE SQAUREMAGNTIUDE AGAINST ATTACKRADIUS * ATTACKRADIUS//

            if(LengthofDirtoPlayer < AttackRadius * AttackRadius)
            {
                
                Debug.Log("Chase Player");

                //THIS NORMALIZES THE DIRECTION, MAKING IT A LENGTH OF ONE//
                DirtoPlayer = DirtoPlayer.normalized;

                //THIS LINE MAKES THE ENEMY FASTER EVERY OR EACH FRAME//
               
                //ADDING TO VELOCITY MAKES ACCELERATION//

                //EACH FRAME THE VELOCITY INCREASES AND SAVES THE RESULT BACK INTO LINEARVELOCITY//
            
                //rb.linearVelocity = rb.linearVelocity + (DirtoPlayer * speed * Time.deltaTime);

                //THIS LINE FORCES THE SPEED TO BE THE EXACT VALUE EACH FRAME//
                rb.linearVelocity = DirtoPlayer * speed;

           
           
            }



            


       
       
       
        }


   
   
    }
   
   

   public class PlayerStats
   {
        
   // public Dictionary<string, int> Stats = new Dictionary<string, int>();


    //THIS IS A CONSTRUCTOR THAT AUTOMATICALLY RUNS WHEN YOU CREATE A OBJECT FROM THIS CLASS//

    //CONSTRUCTORS -> INITIALIZE YOUR OBJECT, SET UP DEFAULT VALUES, AND PREPARE EVERYTHING SO ITS READY TO USE//

    //CONSTRUCTORS HAVE THE SAME NAMES AS THE CLASS AND NO RETURN TYPE//

    public PlayerStats()
    {

      //  Stats = new Dictionary<string,int>();  

      //  Stats["Health"] = 0;



        //STATS.Keys -> GIVES YOU ONLY KEYS OF THE DICTIONARY//
       // foreach(var key in Stats.Keys)
        //{

            //Stats[key] = 0;
                
       // }





    
    
    
    }
    
    

 
    
   
   
   }


   //PART 2: ON CLASSES//

    // A CLASS IS A BLUEPRINT FOR CREATING AN OBJECT//

    // 1) AN OBJECT IS AN INSTANCE OF A CLASS:

        //EX: Player player1 = new Player();
              //Player player2 = new Player();

    // 1A) EACH OBJECT HAS ITS OWN DATA


    //CLASS ANATOMY:

    //1) FIELDS -> STORE DATA
   
    //2) METHODS -> PERFORM ACTIONS


    //3) CONSTRUCTOR -> SETS UP DATA AUTOMAITICALLY//
   
   public class PlayerType
  {
    // FIELDS
    public int health;

    // POPERTIES
    public int Health { get; set; }

    // CONSTRUCTOR//
    public PlayerType()
     {


        Health = 100;


    }


    public PlayerType(int Health)
    {
            
        health = Health;



    }

    // METHODS
    public void Move()
    {
    }

    // EVENTS
    public event Action OnDeath;
}
   


//CLASS FOR A DOG//

public class Dog
{
    

   // FIELDS//
    private string name;

    private int Age;

    private float weight; 

 
    


    public Dog(string Custom, int age, float Weight)
     {
            

        name = Custom;

        Age = age;

        weight = Weight;



     }


     //FUNCTION FOR BARKING//


     public void Bark()
     {
            
        Debug.Log("Bark");



     }




 }
    


    public Player P1 = new Player();

    public Dog Kane = new Dog("Kane", 7, 105);


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //MAKE A PLAYER OBJECT FROM THE PLAYER CLASS//
        P1.TakeDamage(100);


        //MAKE A DOG OBJECT FROM TH DOG CLASS//

        //Kane.Bark();






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
