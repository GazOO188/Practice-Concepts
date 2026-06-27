using UnityEngine;
using System;
using System.Collections.Generic; //THIS NAMESPACE IS VERY IMPORTANT TO INCLUDE FOR LISTS//

public class ListPractice : MonoBehaviour
{
   
    //THIS SCRIPT IS FOR PRACTICING LISTS//

    
    //LIST OF GAMEOBJECTS//
    public List<GameObject> Enemies = new List<GameObject>();




    //LIST OF PLAYER OBJECTS FROM PLAYER CLASS//
    public List<player> Players = new List<player>();


    //LIST OF AGRESSOR OBJECTS FROM AGRESSOR CLASS//
    public List<Agressor> aggs = new List<Agressor>();


    //SORTING PRACTICE WITJH FUNCTIONS//
    public List<int> Numbers = new List<int>();


    //INT//
    public int Score = 0;


    //STRING//

    public string ScoreTitle;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //ADD GAMEOBJECTS AND PLAYERS TO THE LIST//
         player P1 = new player(100, 10f);
         player P2 = new player(100, 5f);

         
        
        //ADD PLAYERS OBJ INTO PLAYER LIST//
         Players.Add(P1);
         Players.Add(P2);


         //MAKE NEW AGGRESSOR OBJS//
         Agressor Ag1 = new Agressor("Jules", 100, 10f);
         Agressor Ag2 = new Agressor("Joe", 50, 20f);


         //ADD THE AGRESSOR OBJS TO THE LIST//
         aggs.Add(Ag1);
         aggs.Add(Ag2);



        //PRACTICE USING FOREACH LOOPS WITH LIST//
        foreach(player objs in Players)
        {
            
            Debug.Log("This is Player : " +  objs.health);

        }

        foreach(player obj in Players)
        {
            
            obj.health = 150;



        }


        //ADD NUMBERS TO LIST//
        Numbers.Add(1);
        Numbers.Add(2);
        Numbers.Add(3);
        Numbers.Add(4);
        Numbers.Add(5);
        Numbers.Add(6);



        //USE THE REMOVE ODD NUMBERS FUNCTION//
        //YOU CAN WRITE IT LIKE THIS BECAUSE THE FUNCTION RETURN A LIST//
        List<int> OddNumberList = RemoveOddNumbers(Numbers);



        foreach(int odd in OddNumberList)
        {
            
          //  Debug.Log("Numbers in list: " + odd); 
        }


        //USE THE SPECIAL ENEMY FUNCTION

        List<GameObject> SpecialEnemies = SortSpecialEnemies(Enemies);


        foreach(GameObject SpecialObj in SpecialEnemies)
        {
            
            Debug.Log("Special Enemies : " + SpecialObj);




        }



        ScoreTitle = AssignPlayerRankTitle(Score);


        Debug.Log(ScoreTitle);
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }


    public void CheckPlayerHealth()
    {

       for(int i = Players.Count - 1;  i >= 0; i--)
        {
            //IF ONE OF THE PLAYERS ARE NULL OR DOSEN'T EXIST, REMOVE. IT
            if(Players[i] == null)
            {
                
                Players.RemoveAt(i);
                continue;

            }


            //IF ONE OF THE PLAYER OBJ'S HEALTH IN THE LIST IS BELOW 0, REMOVE IT FROM THE LIST//
            if(Players[i].health <= 0)
            {
                //REMOVE THE PLAYER AT THE SPECIFIC INDEX WITH THE LOW HEALTH//
                Players.RemoveAt(i);

                Players[i].Die();


            } 


        }



    }



    //SORT NUMBERS OR REMOVE NUMBERS FROM LIST BY ODD//

    //THIS FINCTION RETURNS A BRANND NEW LIST WITH ALL THE ODD NUMBERS IN IT//
    public List<int> RemoveOddNumbers(List<int> ExistingList)
    {
        
        //STEP 1: MAKE A NEW LIST//
        List<int> FilteredList = new List<int>();


        //STEP 2: GO THROUGH ALL THE INTS IN THE EXISTING LIST// 
        foreach(int OddNum in ExistingList)
        {
            
            //IF THE NUMBER IS NOT 
            if(OddNum %2 != 0)
            {
                
        
            FilteredList.Add(OddNum);
            
            }

        }

        return FilteredList;
    }


    //THIS FUNCTION IS FOR GAMEOBJECTs//
    public List<GameObject> SortSpecialEnemies(List<GameObject> ExistingEnemyList)
    {
        
        //STEP 1: MAKE A NEW LIST TO SORT THE NEW ENEMIES INTO//
        List<GameObject> SpecialEnemies = new List<GameObject>();


        //USE A FOREACH LOOP TO LOOP THROUGH EACH ELEMENT IN THE EXISTING ENEMY LIST
        foreach(GameObject Special in ExistingEnemyList)
        {
            //IF A GAMEOBJECT IN EXISTINGENEMYLIST HAS THE SPECIAL ENEMY LIST ADD IT TO THE SPECIAL ENEMY LIST//

            if (Special.CompareTag("SpecialEnemy"))
            {
            
                SpecialEnemies.Add(Special);
            }


        }

        //DELIVERS THE OUTPUT LIST BACK//
        return SpecialEnemies;
    }


    //THIS FUNCTION IS FOR CLASS OBJECTS//
   // public Dictionary<GameObject, int> ToughEnemies(Dictionary<GameObject, int> originalEnemies)
    //{
        
        //MAKE A NEW DICTIONARY OF ENEMIES TO ASSIGN VALUES TO//
       // Dictionary<GameObject, int> harderEnems = new Dictionary<GameObject, int>();

  //  }



    //EXAMPLES WITH OTHER DATA TYPES LIKE STRINGS W/O USING LISTS/


    public string AssignPlayerRankTitle(int score)
    {
        
        //BRONZE THRESHOLD//
        if(score >= 0 && score <= 50)
        {
            

            return "Bronze";
        
        }


        

        //GOLD THRESHOLD//
        if(score > 50 && score < 80)
        {
            
            return "Gold";



        }



        //PLATINUM THRESHOLD//
        if(score >= 80 && score <= 100)
        {
            
            return "Platinum";


        }





        return "Supremacy";

    }



    //THIS FUNCTION IS FOR INT//
    public int CalculateDamage(int baseDamage, bool IsaCrit)
    {


        if (IsaCrit)
        {
            
            return baseDamage * 2;



        }



        return baseDamage;




    }




    

//THIS IS A PLAYER CLASS//
public class player
{

    public int health;

    public float speed;


    //CONSTRUCTOR//
    public player(int MaxHealth, float MaxSpeed)
    {
       

        //MAKE SURE HEALTH IS FIRST, SO MAXHEALTH SAVES INTO THE VARIABLE AND FOR THE OTHER//
        health = MaxHealth;

        speed = MaxSpeed;



    } 



    public void Die()
    {
        
        if(health <= 0)
        {

            Debug.Log("Die");   



        }




    }  

}

//AGGRESSOR CLASS//

public class Agressor
{
    
    public string name;

    public int health = 100;

    public float speed = 5f;




    public Agressor(string customName, int MaxHealh, float Maxspeed)
    {
        
        name = customName;


        health = MaxHealh;


        speed = Maxspeed;



    }



}

}