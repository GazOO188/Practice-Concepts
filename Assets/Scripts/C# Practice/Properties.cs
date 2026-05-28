using UnityEngine;

public class Properties : MonoBehaviour
{
    
    //THIS SCRIPT IS FOR PROPERTIES//


    //PROPERTIES EXIST TO GRAB OR CHANGE THE FIELDS//


    //A PROPERTY IS TWO METHODS TRYING/PRETENDING TO BE A VARIABLE//

    [SerializeField] private int Health = 100;


    //AUTO-PROPERTY//

    //THIS AUTOMATICALLY CREATES THE PROPERTY FROM BELOW:

        // 1) private int health;
        // 2) public int Health
        //{ get { return health; } set { health = value; }
//}
  //  public int Health{ get; set; }


    //TO CREATE A PROPERTY//

    public int PlayerHealth
    {

        get
        {
            
            return Health; 


        }


        //SET IS FOR SETTING THE VALUE YOU CAN WRITE YOUR IF STATEMENTS IN SET
    
        set
        {
            
            //VALUE MEANS THE NEW VALUE BEING ASSIGNED//
           // Health = value;


            if(Health <= 0)
            {
                
            Debug.Log("Dead");



            }


           Health = Mathf.Clamp(value, 0, 100);



        }
    }


    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerHealth = 40;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
