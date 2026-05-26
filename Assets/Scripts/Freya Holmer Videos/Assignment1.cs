using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    //THIS IS A PRACITCE ASSSIGNMENT FROM THE VIDEO//

    //1) RADIAL TRIGGER

    //2) BOUNCING LASER


    public Transform Player;

    public Transform Trigger;


    public float radius = 5f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CONVERT/GET TRASNFROM.POSITION AND SAVE IT INTO VECTOR3//
        Vector3 PlayerPos = Player.position;

        Vector3 TriggerPos = Trigger.position;



        //GET THE DIRECTION FROM THE PLAYER TO THE TRIGGER//

        Vector3 DirToTrigger = TriggerPos - PlayerPos;


        
        //GET THE SQUARE MAGNITUDE OF THE DIRECTION//

        //SQRMAGNITUDE IS FOR COMPARING DISTANCES//

        //MAGNITUDE IS A BIT MORE EXPENSIVE THAN SQAURE MAGNITUDE WHICH USES A MAGNITUDE//

        //SQUARING MEANS NUMBER * NUMBER//


        float SQRMAGNITUDEofDir = DirToTrigger.sqrMagnitude;


        bool Isinside = SQRMAGNITUDEofDir <= radius * radius;

       
        if(Isinside)
        {
            
            Debug.Log("InTrigger");
       
       
        }





    }




}
