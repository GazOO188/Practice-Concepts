using System;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class Trigonmetry : MonoBehaviour
{
  
    //THIS SCRIPT IS FOR TESTING TRIGONMETRY//

    //THIS IS A SLIDER TO CHANGE THE ANGLE BASED ON THE VECTOR//

    //THIS GOES BETWEEN 0-360 A FULL CIRCLE//


    // 1) 0 DEGREES POINTS RIGHT
   
    // 2) 90 DEGREES POINTS UP
    
    // 3) 180 DEGREES POINTS LEFT
    
    // 4) 270 DEGREES POINTS DOWN


    [Range(0,360)]
    public float angle = 90f;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //THIS IS A HELPER FUNCTION THAT CONVERTS ANGLE TO DIRECTION//

    //IN THE UNIT CIRCLE:

    // 1) COSINE TELLS YOU HOW FAR LEFT/RIGHT

    // 2) SIN TELLS YOU HOW FAR UP/DOWN

    //THIS LINE IS CREATING A UNIT DIRECTION VECTOR POINTING AT THE ANGLE//

    //NEGATED IT SO 0 DEGREES STARTS RIGHT AND THEN GOES COUNTERCLOCKWISE//

    Vector3 AngletoDir(float angleinRadians) => new Vector3(-Mathf.Cos(angleinRadians), Mathf.Sin(angleinRadians), 0);

    void OnDrawGizmos()
    {
        

        Handles.DrawWireDisc(Vector3.zero, Vector3.forward, 1);


        //MATHF.DEG2RAD -> PI/180//

        //THIS IS THE SAME AS  angle * (Mathf.PI / 180f);

        float angleinRadians = angle * Mathf.Deg2Rad;

        //COSINE ACCEPTS RADIANS, NEED ANGLE IN RADIANS//
        Vector3 V = AngletoDir(angleinRadians);


        //THIS DRAWS A RAY STARTING AT THE ORIGIN AND POINTING IN THE DIRECTION OF THE ANGLE//
        Gizmos.DrawRay(default, V);


    }




}
