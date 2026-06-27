using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float MoveSpeed = 5f;

    [Header("Jump Settings")]
    [SerializeField] private float JumpForce = 8f;
    [SerializeField] private int maxJumps = 1; 

    [Header("Rigidbody Settings")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float fallMultiplier = 2.5f;

    [Header("Ground Check")]
    [SerializeField] private LayerMask Ground;
    [SerializeField] private Transform PlayerPos;

    [Header("Bools")]
    [SerializeField] private bool isGrounded;
    [SerializeField] private bool canJump = false;
    [SerializeField] private bool hasJumped = false;

    [SerializeField] private int jumpsRemaining;

    void Start()
    {
        jumpsRemaining = 0;
    }

    void Update()
    {
        // INPUT
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //CONVERT INPUT INTO A DIRECTION
        Vector3 direction = (transform.right * x + transform.forward * z).normalized;

        //MOVE BASED ON DIRECTIO//
        transform.position += direction * MoveSpeed * Time.deltaTime;

        // HANDLE JUMP FUNCTION//
        Jump();

        // COUNT AIR JUMPS
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isGrounded)
            {
                jumpsRemaining++;
            }

            hasJumped = true;
        }
    }

    void FixedUpdate()
    {
        // FASTER FALLING
        if (rb.linearVelocity.y < 0f)
        {
            rb.linearVelocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
        }

        //THIS IF STATEMENT MAKES THE PLAYER JUMP WITH RIGIDBODY//
        if (canJump && hasJumped)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, JumpForce, rb.linearVelocity.z);

            canJump = false;
        }
    }


    //JUMPING FUNCTION//
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining <= maxJumps)
        {
            canJump = true;
        }


        //RESETS JUMP//
        if (jumpsRemaining > maxJumps)
        {
            canJump = false;
            hasJumped = false;
        }
    }


    //FOR DETECTING THE GROUND//
    bool DetectGround()
    {
        return Physics.Raycast(PlayerPos.position, Vector3.down, 1.1f, Ground);
    }



    //FOR DETECTING IF THE PLAYER COLLIDES WITH THE GROUND//
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;

            //RESET JUMP COUNT//
            jumpsRemaining = 0;

            hasJumped = false;
        }
    }


    //WHEN THE PLAYER LEAVES THE GROUND//
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
        }
    }
}