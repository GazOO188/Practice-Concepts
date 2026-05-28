using UnityEngine;
using System.Collections.Generic;

public class DataTypes : MonoBehaviour
{
    //TYPES OF DATA//


    //1) INT -> STORES WHOLE NUMBERS//

    //USE -> HP, SCORE, LIVES, AMMO, ETC//

    public int lives = 10;

    public int Hp = 100;

    public int Ammo = 50;


    //2) FLOAT STORES DECIMAL NUMBERS 

    //USE->  TIME, MOVEMENT SPEED, PHYSICS, ROTATION

    public float Timer = 8.2f;

    public float MoveSpeed = 3.2f;

    public float JumpForce = 2.3f;


    //3) STRING -> STORES TEXT//

    //USE -> NAMES, ETC//


    public string WeaponName;

    public string PlayerName;



    //4) VECTOR2/VECTOR3 -> STORES X AND Y POSITION//

    //USE -> 2D MOVEMENT, 2D VELOCITY,

    public Vector2 MoveDirection = new Vector2(1,0);


    // VECTOR3 FOR X, Y, Z

    // X IS LEFT & RIGHT

    // Y IS UP AND DOWN//

    public Vector3 PlayerPos = new Vector3(0,3,2);



  




    //5) QUATERNION -> REPRESENTS ROTATION//


    Quaternion Rotation = Quaternion.Euler(0,90,0);



    //6) COLOR -> STORES COLOR VALUES//


    //7) TRANSFORM -> REPRESENTS POSITION, ROTATION, SCALE


    //8) GAMEOBJECT -> REPRESENTS AN OBJECT IN THE SCENE//

    public GameObject Ogre;

    
    
    
    //9) COLLECTIONS (DATA TYPE) -> STORE  MULTIPLE VALUES


    //1) ARRAYS -> FIXED-SIZE COLLECTION.  -> GOOD FOR TILE GRIDS, FIXED INVENTORY SLOTS, MAP DATA

      
      int[] scores = {10, 20, 30};



    //2) LISTS -> DYNAMIC COLLECTION -> GOOD FOR ENEMIES, INVENTORIES, LOOT, QUESTS//



    List<string> inventory = new List<string>();



    //3) DICTIONARIES -> STORES KEY/VALUE PAIRS


    Dictionary<string, int> items = new Dictionary<string, int>();

    Dictionary<GameObject, int> Enemy = new Dictionary<GameObject, int>();



    //4) HASHSETS//


    //5) QUEQUES//


    
    //BOOLS//

    public bool IsOpen = false;

    public bool isDead = false;



    //ENUMS -> NAMED STATES//
    public enum WeaponType
    {
        
        Sword,

        Bow,

        Shotgun,

        AssaultRifle,



    }

    public WeaponType CurrentWeapon = WeaponType.AssaultRifle;



    //CLASSES


    public class EnemyThing
    {
        

        public int EnemyHealth = 100;


        public float EnemSpeed = 3.2f; 




    }




  //COMPONENTS/

  //YOU CAN ACCESS COMPONENTS ON GAMEOBJECTS TO CHANGE THEM//


  // RIGIDBODY IS IN CONTROL OF THE PHYSIC AND YOU CAN USE 

  public Rigidbody2D rb;



  //USE SERIALIZEFIELD FOR EDITING IN THE SCENE OR IF YOU WANT TO SEE THEM IN THE IMMSPECTOR//


  //MUCH BETTER TO KEEP THINGS PRIVATE, MUCH BETTWER TO KEEP THINGS PRIVATE, UNLESS YOU HAVE A REASON TO KEEP THEM PUBLIC//


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      inventory.Add("Sword"); 

      inventory.Add("Pulse Rifle");



      items["Health Potion"] = 5;

      
      
      Enemy[Ogre] = 1000;



      Ogre.transform.position = PlayerPos;


      rb = GameObject.Find("Ogre").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


      if(Ogre != null)
      {
      

        CurrentState(WeaponType.Bow);


      }

  

        
    }



    //METHODS//
    //USING A SWITCH STATEMENT WITH ENUMS//

    public void CurrentState(WeaponType Type)
    {


    switch (Type)
    {
      
      
      case WeaponType.Sword:
      {
          
        Debug.Log("Sword");

        break;



      }


      case WeaponType.Bow:
      {
          
        Debug.Log("Bow");

        break;



      }


      case WeaponType.Shotgun:
      {
          

        Debug.Log("Shotgun");

        break;


      }


      case WeaponType.AssaultRifle:
      {
          

        Debug.Log("Assault Rifle");

        break;



      }
    




    }




   }




}

