using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dictionaries : MonoBehaviour
{
    
    //ENUM PRACTICE//

    public enum WeaponTypes
    {
        AutoRifle,

        Submachine,

        ScoutRifle,

        Shotgun,

        Sword,

        Glaive,


    
    
    }


    //MERGE ENUMS WITH DICTIONARIES//


    private Dictionary<WeaponTypes, float> WeaponSubClasses = new Dictionary<WeaponTypes, float>();



    //DICTIONARY PRACTICE//

    private Dictionary<string, int> enemyHealth = new Dictionary<string, int>();


    private Dictionary<GameObject, float> SpecialInfected = new Dictionary<GameObject, float>();


    //A DICTIONARY THAT TRACKS GAMEOBJECTS WITH ITS ASSOICATED COOUTINE//

    private Dictionary<GameObject, Coroutine> TrackCoroutines = new Dictionary<GameObject, Coroutine>();


    //A DICTIONARY THAT CONTAINS WEAPONS//
    
    private Dictionary <String, float> Weapons = new Dictionary<String, float>();


    public GameObject Clone, Boomer, Smoker, Spitter, Jockey, Hunter, Witch, Tank, Charger;


    private Coroutine FadeCoroutine;



    public float CritMultiplier, fusiondmg;




    //BOOLS//

    public bool IsShotAt = false;



    //KEYWORDS IN FUNCTIONS:
   
         //BREAK IN FOR LOOPS IMMEDIATELY EXITS THE LOOP//

         //CONTINUE -> CONTINUE KEYWORD SKIPS THE CURRENT LOOP ITERATION AND MOVES TO THE NEXT ITERATION//

         //RETURN  ->  EXITS THE ENTIRE FUNCTION, STRONGER THAN BREAK//
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //ADD VALUES TO DICTIONARY//

        enemyHealth.Add("Orc", 200);

        enemyHealth.Add("Boomer", 100);


        //SET GOBLIN HEALTH TO 75//

        enemyHealth.Add("Goblin", 75);


        //SET BOOMER HEALTH TO 100//


        enemyHealth.Add("Boomer Female", 100);


        TrackCoroutines.Add(Clone, FadeCoroutine);



        //ADD SONE WEAPONS//

        Weapons.Add("Glacioclasm", 3.5f);


        Weapons.Add("Relentless", 7.5f);



        //ADD DAMAGE VALUE TO SPECIFIC WEAPON TYPES//


        WeaponSubClasses.Add(WeaponTypes.AutoRifle,  5.6f);



        //ADD SOME SPECIAL INFECTED INTO THE DICTIONARY//


        SpecialInfected.Add(Boomer, 50f);

        SpecialInfected.Add(Hunter, 250f);
        
        SpecialInfected.Add(Jockey, 350f);

        SpecialInfected.Add(Spitter, 100f);




   
   
    }

    // Update is called once per frame
    void Update()
    {
        changeValues();
        
    }



    //CHANGE VALUES OF THE ENEMIES IN THE DICTIONARIES//



    public void changeValues()
    {

        if (IsShotAt)
        {
            
            //THIS SUBTRACTS 25 FROM THE CURRENT VALUE OF BOOMER'S HEALTH IN THE DICTIONARY//
            enemyHealth["Boomer"] = enemyHealth["Boomer"] - 25;

            enemyHealth["Orc"]-= 50; // Or enemyHealth["Orc"] = enemyHealth["Orc"] - 50;


            //MAKE RELENTLESS DO MORE DAMAGE//
            Weapons["Relentless"] = 3.5f * CritMultiplier;

       
       
       
        }

        //IF THE DICTIONARY CONTAINS A KEY CALLED BOOMER WE ARE GOOD AND ITS IN

        if (enemyHealth.ContainsKey("Boomer"))
        {
            
       
            UnityEngine.Debug.Log("Boomer is in");
       
        }




        //IF THE BOOMER KEY'S VALUE IS 0, BOOMER DIED//


        if (enemyHealth.ContainsKey("Boomer"))
        {
            
        


        if(enemyHealth["Boomer"] <= 0)
        {
           UnityEngine.Debug.Log("Bommer is dead");

        
           //REMOVE BOOMER FROM THE DICTIONARY//

           enemyHealth.Remove("Boomer"); 


        }

        }
        else
        {
            
            if(enemyHealth["Boomer"] >= 0)
            {
                
            UnityEngine.Debug.Log("Boomer is alive");
           
            }
       
       
        }



        //CHECKS IF WEAPONS DICTIONARY CONTAINS A KEY CALLED "GLACIOCLASM"
        if (Weapons.ContainsKey("Glacioclasm"))
        {


            //THIS GETS THE CURRENT DAMAGE OF GLACIOCLASM AND MULTIPLIES BY FUSIONDMG//
            Weapons["Glacioclasm"] = Weapons["Glacioclasm"] * fusiondmg;





        }

        //IF THE DICTIONARY HAS BOOMER AND ISSHOT AT, REDUCE HEALTH BY 3.02F;
        if (SpecialInfected.ContainsKey(Boomer) && IsShotAt)
        {

            SpecialInfected[Boomer] -= 3.02f;

            IsShotAt = false;
       
        }





        //SWITCH-CASE PRACTICE//


        //CASE IS LIKE AN IF STATEMENT//


        WeaponTypes Weapon = WeaponTypes.ScoutRifle;


        //THIS CHECKS THE VALUE STORED IN WEAPON AND THEN CHOOSES THE MATCHING CASE BELOW//
        switch (Weapon)
        {

            //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.SWORD)

            case WeaponTypes.Sword:

                 UnityEngine.Debug.Log("Sword");

                 break; //ENDS THIS CASE//


            
             //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.GLAIVE)
            case WeaponTypes.Glaive:

                UnityEngine.Debug.Log("Glaive");

                break; //ENDS THIS CASE//

            
            

            //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.AUTORIFLE)
            case WeaponTypes.AutoRifle:

                UnityEngine.Debug.Log("You have a autorifle");

                break; //ENDS THIS CASE//


           
            //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.SCOUTRIFLE)
            case WeaponTypes.ScoutRifle:
                
                UnityEngine.Debug.Log("ScoutRifle");

                break; //ENDS THIS CASE


           
            //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.SHOTGUN)
            case WeaponTypes.Shotgun:

                UnityEngine.Debug.Log("Shotgun");

                break; //ENDS THIS CASE//
       

            
            //THIS IS LIKE SAYING: IF(WEAPON == WEAPONTYPES.SUBMACINE)
            case WeaponTypes.Submachine:

                UnityEngine.Debug.Log("Submachine");
                
                break; //ENDS THIS CASE//

            
            
            //THIS IS IF NO STATES ARE APPLICABLE OR NOT IN WEAPONS//
            default:

                UnityEngine.Debug.Log("BackUp");
               
                break; //ENDS THIS CASE//


       
       
       
       
        }



        //LOOP THROUGH DICTIONARY//
        //LOOPS THROUGH ALL WEAPONTYPES AND APPLIES A 20% DAMAGE BUFF//

        foreach(WeaponTypes weapon in WeaponSubClasses.Keys)
        {
            
            //GIVE EACH WEAPONTYPE IN WEAAPONSUBCLASSES A 20% BUFF//
            WeaponSubClasses[weapon] *= 1.2f;
       
       
        }



        //USE KEY-VALUE PAIR//

        //IN THE FOREACH STATEMENT USE: KEYVALUEPAIR<WEAPONTYPES, FLOAT> WITH THIS YOU CAN CHECK AND MAKE AN IF STATEMENT TO ADJUST THE VALUES
        foreach(KeyValuePair<WeaponTypes, float> weapon in WeaponSubClasses)
        {
            
            //WEAPON.VALUE MEANS THE VALUE OR FLOAT VALUE, WHILE KEY IS THE WEAPONTYPES//
            //THIS CHECKS IF THE VALUE IS LESS THAN 10//
            if(weapon.Value <= 10f)
            {
                //THE WEAPON.KEY MEANS THE WEAPONTYPES LIKE AUTO RIFLE, KEY IS THE WEAPONTYPES, AND VALUE IS THE FLOAT
                WeaponSubClasses[weapon.Key] = weapon.Value * 1.4f;
                
            
            
            }
        
        
        
        
        }


        

        
    
    
    
    }








}
