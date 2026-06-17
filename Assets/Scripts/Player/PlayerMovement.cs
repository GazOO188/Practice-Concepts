using UnityEngine;

using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    // THIS SCRIPT IS FOR PLAYER MOVEMENT//


    public float MoveSpeed;


    [Header("Jump Settings")]
    [SerializeField] private float JumpForce;


    [Header("Rigidbody Settings")]
    
    [SerializeField] private Rigidbody rb;



    [Header("Bool Settings")]
    
    [SerializeField] private bool CanJump = false;
   
    [SerializeField] private bool AllowedtoJump = false;

    [SerializeField] private bool TrackOnce = false;

    [SerializeField] private bool CanDoubleJump = false;


    [Header("Variables")]
    
    [SerializeField] public int TimesCanJump = 0;
       


    [Header("LayerMask Settings")]

    [SerializeField] private LayerMask Ground;



    [Header("Transform Settings")]
    [SerializeField] private Transform PlayerPos;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //GET INPUT FROM PLAYER//

        float x = Input.GetAxisRaw("Horizontal");

        float z = Input.GetAxisRaw("Vertical");



        //TURN INPUT INTO A DIRECTION//

        Vector3 DirectionBasedOnInput = (transform.right * x + transform.forward * z).normalized;



        //MULTIPLY DIRECTION WITH SPEED//


        Vector3 Movement = DirectionBasedOnInput * MoveSpeed;



        //APPLY MOVEMENT//

        transform.position += Movement * Time.deltaTime;




        //CHECK IF THE RAY IS HITTING THE FLOOR AND ALLOW JUMPING//


        bool IsGrounded = DetectGround();

        if (IsGrounded)
        {
            CanJump = true;


     
             
             //IF PLAYER IS GROUNDED, THEY ARE ALLOWED TO JUMP//
             if (Input.GetKeyDown(KeyCode.Space) && CanJump)
             {
            
                StartCoroutine(ToggleJumping());

                TimesCanJump++;


             }

           //  Debug.Log("Touching the Ground");


           TimesCanJump = 0;

           CanDoubleJump = false;

        }



        else
        {

               
            //OFF THE GROUND//
            if (!IsGrounded && TimesCanJump % 2 == 0)
            {
                
              
                if (Input.GetKeyDown(KeyCode.Space) && !CanDoubleJump)
                {
                   
                     StartCoroutine(ToggleJumping());

                     CanDoubleJump = true;

                     TimesCanJump++;

                }


              


            
            


            }


           


        }






        }


      
    

      
        
    




    void FixedUpdate()
    {
        


        //THIS IS FOR JUMPING//
        if (AllowedtoJump)
        {
            
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

        }

    }



    //BOOL FOR DETECTING GROUND//

    //PHYSICS.RAYCAST RETURNS A BOOL//
    private bool DetectGround()
    {
        

        return Physics.Raycast(PlayerPos.position, Vector3.down, 2f, Ground);




    }



    //COROUTINE//

    public IEnumerator ToggleJumping()
    {
        
        yield return new WaitForSeconds(0f);


        AllowedtoJump = true;



        yield return new WaitForSeconds(0.3f);


        AllowedtoJump = false;

        CanJump = false;

       


    }




}
