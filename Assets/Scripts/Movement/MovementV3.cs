using UnityEngine;

public class MovementV3 : MonoBehaviour
{
    //ANOTHER WAY OF DOING MOVEMENT WITH TRANSFORM//


    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //1) GET INPUT//


            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");


        //2) GET DIRECTION//


            Vector3 Direction = new Vector3(x, 0, z);



        //3) NORMALIZE THE DIRECTION//


            Direction = Direction.normalized;


        //4) APPLY SPEED//

            Vector3 Movement = Direction * speed;



        //5) MOVE //



            transform.position += Movement * Time.deltaTime;







        
    }
}
