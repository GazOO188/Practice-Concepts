using UnityEngine;

public class Methods : MonoBehaviour
{
    //THIS SCRIPT IS FOR METHODS//


    //METHODS ARE FUNCTIONS THAT STORE DATA/LOGIC IN THEM//



    //TWO TYPES OF METHODS:

        //1) METHODS THAT RETURN A VALUE//
        //2) METHODS THAT DON'T RETURN ANYTHING//
   

    //SOME VARIAIBLES TO USE//

    public int Health = 100;

    public int Dmg;

    public float PlayerSpeed = 3.7f;

    public bool IsDead;

    public bool IsNear;


    public Rigidbody rb;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //METHODS//

    public void TakeDamage()
    {
        
        ///LOGIC TO TAKE DAMAGE//
        

        Health -= Dmg;




    }

    //VARIANT 2 OF TAKEDAMAGE()


    public void TakeDamage2(int Damage)
    {
        
        Health -= Damage;


        if(Health <= 0)
        {
            
            Health = 0;



        }

        Health = Mathf.Clamp(Health, 0, 100);




    }



    //HEAL FUNCTION//


    public void HealAmount(int Amount)
    {
        
        Health += Amount;


        //MAKES SURE IT DOSEN'T GO OVER//
        Health = Mathf.Clamp(Health, 0, 100);


    }



    //METHOD FOR JUMPING//
    public void ApplyJump()
    {

       // if (Input.GetKeyDown(Space))
       // {
            
           // rb.AddForce(Vector3.Up * 5.2f);




       // }



    }


    //BOOL METHOD FOR DETERMINING IF ENEMY IS CLOSE TO PLAYER//
    public bool IsNearby(Vector2 enemy, Vector2 playerPos)
    {
    Vector2 dir = playerPos - enemy;

    if(dir.magnitude < 5f)
    {
        return true;
    }

    return false;
    }




    





}
