using UnityEngine;

public class Movement : MonoBehaviour
{
     //PRACTICE MOVEMENT SCRIPT//

     public float MovementSpeed;


     //GET INPUT VALUES//

     public float x, z;


     //REFERENCE TO TRANSFORM OF PLAYER//

     public Transform Player;

     //REFERENCE TO RIGIDBODY//


     public Rigidbody PlayerRb;


    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    //RULES OF MOVEMENT USING A RIGIDBODY:

        //SETUP
        
        //  1) GET A REFERENCE TO THE TRANSFORM
       
        //  2) GET A REFERENCE TO THE RIGIDBODY COMPONENT ON THE PLAYER

        //  3) OPTIONAL: MAKE FLOAT VALUES FOR THE X AND Z INPUT VALUES// -> X = HORIZONTAL MOVEMENT,  Z = FORWARD/BACKWARD MOVEMENT,  Y = OPTIONAL DEPENDING ON IF YOU WANT VERTICAL MOVEMENT..


        //IMPLEMENTATION OF MOVEMENT:


        // 1) GET INPUT FORM THE PLAYER -> X, Z, OR Y (OPTIONAL)

        // 2) CONVERT INPUT INTO A DIRECTION LOCALLY OR WORLD//

        // 3) NORMALIZE THE INPUTDIRECTION SO DIAGONAL MOVEMENT ISN'T FASTER || ALLOWS FOR CONSISTENT MOVEMENT//

        // 4) APPLY THE NORMALIZED DIRECTION USING RB.LINEARVELOCITY AND MULTIPLY BY MOVEMENT SPEED//

            // NOTES:
           
            // 1)  NEVER MULTIPLY Rigidbody.LINEARVELOCITY BY TIME.DELTATIME

            // 2)  RB.LINEARVELOCITY IS UNITS/SECOND

                // PlayerRb.linearVelocity = InputDirection * MovementSpeed; 

                    // THIS MEANS "MOVE AR MOVEMENTSPEED UNITS EVERY SECOND IN THIS DIRECTION".






    void FixedUpdate()
    {
        //GET INPUT FROM THE PLAYER FIRST//
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");


        //CONVERT INPUT INTO DIRECTION LOCALLY//
        Vector3 InputDirection = (Player.transform.right * x) + (Player.transform.forward * z);

       
        //NORMALIZE DIRECTION TO NOT MAKE DIAGONAL MOVEMENT FASTER//
        InputDirection = InputDirection.normalized;


        //APPLY SPEED TO PLAYER RIGIDBODY TO MAKE PLAYER MOVE//
        PlayerRb.linearVelocity = InputDirection * MovementSpeed;



    }




}
