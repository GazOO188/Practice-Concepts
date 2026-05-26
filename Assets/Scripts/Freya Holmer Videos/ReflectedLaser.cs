using UnityEngine;

public class ReflectedLaser : MonoBehaviour
{
    //THIS SCRIPT HANDLES LASER REFELCTION//


    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnDrawGizmos()
    {
        
        Vector3 origin = transform.position;


        Vector3 direction = transform.forward;


        Ray ray = new Ray(origin, direction);


        Gizmos.DrawLine(origin, origin + direction);


        //THIS FOR RAYCASTING//


        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            //THIS DRAWS A SPHERE AT THE LOCATION OF WHERE THE RAYCAST HITS//
            Gizmos.DrawSphere(hit.point, 0.2f); 
       
       
        }


    }



}
