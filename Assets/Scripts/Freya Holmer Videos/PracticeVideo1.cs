using UnityEngine;

public class PracticeVideo1 : MonoBehaviour
{
    //PRACTICE FROM VIDEO 1 FREYA HOLMER//

    public Transform Player;

    public Transform Enemy;


    //FLOAT VALUE FOR DOT PRODCUT//


    public float DotValue;

   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //DRAWS IN THE SCENE VIEW//

    //NOTES:

    //IF YOU ARE ONLY COMPARING DISTANCES-> USE SQRMAGNITUDE
        
        // 1) USE SQRMAGNITUDE WHEN COMPARING DISTANCES
        
        // 2) WHEN DOING ENEMY RANGE CHECKS

        // 3) AI DETECTION

        // 4) ANYTHING INSIDE UPDATE()

        // 5) SQRMAGNITUDE IS THE NUMBER BEFORE TAKING THE SQUARE ROOT


    // USE MAGNITUDE/DISTANCE WHEN:

        // 1) YOU NEED THE ACTAUAL DISTANE NUMBER//
        
    
    //IF YOU NEED THE REAL DISTANCE VALUE -> USE MAGNITUDE
    void OnDrawGizmos()
    {
        //YOU CAN MAKE VECTOR3 VARAIBLES FROM TRANSFORM B/C TRANSFORM.POSITION IS ALREADY A VECTOR3 VARAIBLE (0,0,06)
        Vector3 a = Player.position;

        Vector3 b = Enemy.position;


         
        //TO NORMALIZE//

        Vector3 aNormalized = a.normalized;  // OR a/aLength;

        Vector3 bNormalized = b.normalized;  // OR b/bLength;



        //DIRECTION SECTION//

        //GET THE DIRECTION FROM A TO B//
        Vector3 DirectionFromAtoB = b - a;

        //NORMALIZE THE DIRECTION//
        Vector3 DirectionNormalized = DirectionFromAtoB.normalized;

        //GET THE MAGNITUDE(LENGTH) OF B-A//

        //THE MAGNITUDE(LENGTH) OF B-A IS THE DISTANCE BETWEEN THEM -> SAME AS VECTOR3.DISTANCE()

        //USE SQRMAGNITUDE WHEN COMPARING DISTANCES//

        //LENGTH -> HOW LONG THE VECTOR IS, THE DISTANCE BETWEEN TWO POINTS


        float LengthofAtoB = DirectionFromAtoB.magnitude;


        //Debug.Log("The length is: " + LengthofAtoB);


        //IF THE DISTANCE IS LESS THAN 3 ATTACK//
        if(LengthofAtoB < 3)
        {
            
          //  Debug.Log("Attack");
       
       
       }

       //DIRECTION SECTION END//





        Gizmos.color = Color.red;

        Gizmos.DrawLine(b, a);



       //Gizmos.color = Color.cyan;

       // Gizmos.DrawLine(default, b);




        //NORMALIZING//

        //THIS IS THE LENGTH OF A//
        //float LenghtofA = Mathf.Sqrt(a.x *a.x + a.y * a.y + a.z * a.z);

        //THIS IS THE SAME AS SQRT. SQRT = MAGNITUDE, GETS THE LENGTH OF A//
        float aLength = a.magnitude;

        float bLength = b.magnitude;





        //SCALAR PROJECTIONS//

        //THIS IS A FLOAT B

        //DOT PRODUCT MEASURES HOW MUCH ONE VECTOR POINTS IN THE DIRECTION OF ANOTHER//
         DotValue = Vector3.Dot(aNormalized, bNormalized);


        
        //Debug.Log("The dot value is: " + DotValue);
   


        //VECTOR PROJECTION//

        Vector3 VectorProjection = aNormalized * DotValue;

        
        
        Gizmos.color = Color.red;

        Gizmos.DrawSphere(VectorProjection, 0.1f);



   
   
   
    }






}







