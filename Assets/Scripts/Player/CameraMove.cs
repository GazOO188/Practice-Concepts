using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //THIS SCRIPT IS FOR CAMERA MOVEMENT//


    private float MouseX, MouseY;


    private float xRotation;


    [SerializeField] private float MouseSensitvity = 5f;


    [SerializeField] private Transform Player;
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //MOUSE INPUT//

        //MOUSE INPUT IS ALREADY FRAME-BASED DON'T NEED TIME.DELTATIME//

        MouseX = Input.GetAxis("Mouse X") * MouseSensitvity;

        MouseY = Input.GetAxis("Mouse Y") * MouseSensitvity;



        
        //X AXIS CONTROLS UP AND DOWN ROTATION SO YOU USE MOUSE Y TO CONTROL HOW FAR UP AND DOWN YOU LOOK//
        xRotation -= MouseY;


        //THIS CLAMPS HOW FAR UP AND DOWN YOU CAN LOOK//
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        //THIS IS FOR LOOKING LEFT IT RIGHT//

        //Y-AXIS ROTATION GOES LEFT AND RIGHT//
        Player.Rotate(Vector3.up * MouseX);








        
    }
}
