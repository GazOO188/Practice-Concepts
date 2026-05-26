using UnityEngine;

public class MovementV2 : MonoBehaviour
{
    //THIS MOVEMENT SCRIPT IS WITHOUT RIGIDBODY AND USING THE TRANSFORM COMPONENT + IT'S FUNCTIONS//


    //REFERENCE TO TRANSFROM VARIABLE, IF THE SCRIPT IS ON THE PLAYER YOU DON'T NEED REFERENCE//


    //REFERENCE TO SPEED//

    [SerializeField] private float Speed;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //GET INPUT VALUES//
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");


        //CONVERT INPUT INTO DIRECTION//

        //THIS MOVES REALTIVE TO WHERE THE PLAYER IS FACING//
        UnityEngine.Vector3 NewDirection = (transform.right * x) + (transform.forward * z);


        //NORMALIZE THE DIRECTION TO NOT MAKE DIAGONAL MOVEMENT FASTER, MAKES THE DIRECTION WITH MAGINTUDE 1//

        // (1,1) IS LONGER THAN (1,0)
        NewDirection = NewDirection.normalized;


        //MAKE VELOCITY VECTOR//

       
        //MULTIPLYING BY TIME.DELTATIME PRODUCES METERS PER FRAME; VELOCITY IS METERS PER SECOND, BUT THIS LINE IS **FRAME DISPLACEMNT**

        UnityEngine.Vector3 Velocity = NewDirection * Speed * Time.deltaTime;


        //APPLY MOVEMENT//
        transform.Translate(Velocity);




        
    }
}
