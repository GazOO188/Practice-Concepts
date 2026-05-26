using System;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScript : MonoBehaviour
{
    //PRACTICE SCRIPT//

    //VARAIBLE PRACTICE//

    //INT VARIABLES//

    public int PlayerHealth = 100; // -> DECLARATION

    public int RoundsCompleted = 0;

    public int Itemfound = 0;

    public int ammoCount = 0;

    public int TimesYouCanJump = 2;

    public int Jumps;

    public int score = 0;

    public int EnemiesKilled = 0;

    public int waveCount = 0;

    public int WretchesDefeated;

    

   
    //FLOAT VARIABLES//
   
    public float PlayerSpeed = 5.5f;

    public float MoveSpeed = 2.4f;
  
    public float CameraSpeed = 9.6f;

    public float gravityInfluence = 9.81f;

    public float reloadspeed = 3.5f;

    public float MouseSensitivity;

    public float JumpHeight;

    public float FlyingSpeed;

    public float timer;

    public float FinalDamage;

   
    //BOOLS//
    public bool IsVisble = true;

    public bool IsAlive = true;

    public bool isNight1 = true;

    public bool CanSpawnUniqueEnemy = false;


    //STRINGS//
    public String PlayerName = "Jules";

    public String FusionRifleName = "Glacioclasm";

    public String AssaultRifleName = "Summoner";

    public String EnemyName = "Hello";

    public String HeroName = "Hero";


    //LIST OF STRINGS//

    public List<String> Items = new List<string>();




    //CHAR//

    public Char Initial = 'J';


    public Char H = 'H';


    public Char Grade = 'A';




    //CONSTANTS//


    public const int MaxHealth = 100;


    public const float MaxJumpHeight = 3.3f;



    //PERCENTS DAMAGE DEBUFF/BUFF//

    public float BaseDamage = 100f;


    public float DamageDebuff = 25f;


    public float DamageBuff = 50f;

    public float damageMultiplier = 1.2f;



    //GAMEOBJECTS//

    public GameObject Enemy, Enemy2, Enemy3, bow;


    //LISTS PRACTICE//

    public List<GameObject> items = new List<GameObject>();

    public List<int> EnemyHealth = new List<int>();


    //ARRAY//

    public int[] TrackEnemyHealthValues = {50, 40, 100, 70, 85, 65};

    //DICTIONARY//

    public Dictionary<GameObject, int> EnemyValues = new Dictionary<GameObject, int>();


    //GAMEOBJECT//

    public GameObject Enemy1;



    


   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PUT ITEMS IN THE LIST OF STRINGS//

        Items = new List<string>{"Potion", "Sword", "Medkit"};

        items.Add(Enemy);

        items.Add(Enemy2);

        items.Add(Enemy3);


        if (items.Contains(bow))
        {
            
            //Debug.Log("Contains bow");
        
        
        }


        //ADD VALUES FOR DICTIONARY//
        EnemyValues.Add(Enemy1, 100);

        
        //ASSIGNS 50 TO THE ENEMY 1 IN DICTIONARY
        EnemyValues[Enemy1] = 50;





        
    }

    // Update is called once per frame
    void Update()
    {


        //VAR//


        var timesCanjump = 5;


        TimesYouCanJump = timesCanjump;



        //MODIFY VARIABLES//

        //  1) Reduce playerHealth by 15

        //  2) Increase score by 30

        //  3) Double playerSpeed

        //  4) Change armor mid-game and print




        //1) Reduce playerHealth by 15//


        PlayerHealth -= 15;

        PlayerHealth = PlayerHealth - 15;


        
        //2) Increase score by 30//


        score += 30;

        score = score + 30;


        
        //3) Double player speed;


        PlayerSpeed *= 2;

        PlayerSpeed = PlayerSpeed * 2;

        
        
        //4)

        PlayerSpeed /= 2;

        PlayerSpeed = PlayerSpeed / 2;


        //4) Change armor mid-game and print


        //Debug.Log("Player has changed armor midgame");



        //BOOLEAN PRACTICE//

        
        if(score <= 0)
        {
            
            IsAlive = false;

            //Debug.Log("Game Over");
        
        
        
        }


        else
        {
            
            IsAlive = true;
        
        
        }


        if(timesCanjump >= 2)
        {
            
         timesCanjump = 0;
        
        
        }



        //OPERATOR PRACTICE//

       
        //Subtract 5 using long form

        //Add 10 using shorthand

        //Multiply by 3 using long form

        //Divide by 2 using shorthand



        int value = 20; //->  DECALRATION //



        //1)Subtract 5 using long form

        value = value - 5;

        value -= 5;

        
        //2)Add 10 using shorthand
        value += 10;

        value = value + 10;

        
        //3)Multiply by 3 using long form. || VALUE *= 2

        value = value * 3;

        value *= 3;

        
        //4)Divide by 2 using shorthand
       
        value /= 2;  // OR VALUE = VALUE /2;

        value = value/2;



        //LETS SAYS THE PLAYER TAKES 25 DAMAGE AND THEIR STARTING HEALTH WAS 100//


        int StartingHealth = 100;


        int FinalDamage = StartingHealth - 25;



        //Subtract 25 from health//

        PlayerHealth = PlayerHealth - 25;

       
        //add 10 back//

        PlayerHealth = PlayerHealth + 10;



        //ANOTHER WAY OD DOING IT IS -> INT STARTINGHEALTH = 100; STARTINGHEALTH -= 25; -> WILL GIVE YOU 75



        //FinalDamage = 75;



        //DEBUG PRACTICE//


       // Debug.Log("PLAYER HEALTH IS:" + PlayerHealth);

       // Debug.Log("MOVESPEED IS:" + MoveSpeed);


        // MODULO PRACTICE//


        //CHECK IF ENEMIESKILLED IS ODD OR EVEN//


        if(EnemiesKilled % 2 == 0)
        {
            
            CanSpawnUniqueEnemy = true;

           // Debug.Log("IsEven");

        
        
        }

        else
        {
            
           // Debug.Log("IsFalse");
        
        
        }


        //SPAWN SPECIAL ITEM EVERY 3RD WAVE//


        //IF WAVECOUNT IS 0-> O % 0 IS 0
        //IF WAVECOUNT IS 1 -> 1 % 3 IS 1
        //IF WAVECOUNT IS 2 -> 2 % 3 IS 2
        //IF WAVECOUNT IS 3 -> 3 % 3 IS 3

        //THE NUMBER AFTER % MEANS EVERY NTH TIME//


        if(waveCount % 3 == 0)
        {
            
           // Debug.Log("Special Item spawned");
       
       
        }

        //EVERY 5 WAVES SPAWN A TANK, CHECK IF WAVECOUNT IS DIVISIBLE BY 5//
        if(waveCount % 5 == 0)
        {
            
            //Debug.Log("Spawn a tank every 5 waves");
        
        
        }


        //EVERY 10 SECONDS SOMETHING HAPPENS//

        if(timer % 10 == 0)
        {
            
        
           // Debug.Log("TRIGGER SOMETHING EVERY 10 SECONDS");
        
        
        
        }



        //PERCENTS PRACTICE//


        BaseDamage = 40f;

        damageMultiplier = 20; //20% DAMAGE BUFF

        float Finaldmg = BaseDamage * (1 + damageMultiplier/100);

        FinalDamage = (int)(FinalDamage - Finaldmg);

       
       
        //FOR LOOPS, WHILE LOOPS, FOREACH PRACTICE//

        //SPAWN 5 ENEMIES
        for(int i = 0; i < 5; i++)
        {
            
           // Instantiate(Enemy, this.gameObject.transform.position, Quaternion.identity);
        
        
        }

        //SPAWN 6 ENEMIES//
        for(int i = 0; i < TrackEnemyHealthValues.Length; i++)
        {
            
            Debug.Log("Enemy:" + i + "has" + TrackEnemyHealthValues[i] + "health");

            if(TrackEnemyHealthValues[i] < 50)
            {
                
               // Debug.Log("HEALTH IS LESS THAN 50");
            
            
            }


            //APPLY RANDOM DAMAGE TO EACH ENEMY HEALTH VALUES//
            int randomDamage = UnityEngine.Random.Range(5, 20);


            //APPLY DAMAGE//
            TrackEnemyHealthValues[i] -= randomDamage;
            
        
        
        
        }


        //AMMO DEPLETION//

        while(ammoCount > 0)
        {
            
            ammoCount--;
        
        
        }


        //FOREACH LOOP//

        foreach(String items in Items)
        {
            
           // Debug.Log("This is item: " + items);
        
        
        
        }



        //BOSS WAVES, LOOP THROGUH THE 11 WAVES AND EVERY 4TH WAVE, SAY IT'S A BOSS WAVE//


        //CHANGE WAVECOUNT TO 1 BECAUSE THERE IS NO SUCH THING AS WAVE 0;

        for(int waveCount = 1; waveCount < 12; waveCount++)
        {
            //EVERY 4 WAVES IS A BOSS WAVE BECAUSE OF MODULO 4//
            if(waveCount % 4 == 0)
            {
                
              //  Debug.Log("Boss Wave");
            
            
            }

            else
            {
                
               // Debug.Log("Regular Wave");
            
            
            }
       
       
       
        }


        //HORDE MODE//


        for(int waveCount = 1; waveCount <= 50; waveCount++)
        {

            //THIS IS SAYING EVERY 10 WAVES, THERE WILL BE A BOSS WAVE//
            if(waveCount % 10 == 0)
            {
                
               // Debug.Log("Boss Wave");
           
           
           
            }



        }


        //LOOP THROUGH 10 ENEMIES AND EVERY 3RD ENEMY IS AN ELITE ENEMY//

        for(int enemy = 0; enemy < 10; enemy++)
        {
            
            //EVERY 3RD WAVE IS AN ELITE ENEMY//
            if(enemy % 3 == 0)
            {
                
               // Debug.Log("Elite Enemy");
           
            }
       
       
       
        }



        //DAMAGE ALL ENEMIES IN THE LIST//

        //LOOPS THROUGH ALL ELEMENTS IN THE ENEMYHEALTH LOOP AND DECREASE INTS BY 25//


        for(int i = 0; i<EnemyHealth.Count; i++)
        {
            
            //DECREASE ALL VALUES BY 25 IN THE LIST//XX
            EnemyHealth[i] -= 25;
       
       
        }




    }
}
