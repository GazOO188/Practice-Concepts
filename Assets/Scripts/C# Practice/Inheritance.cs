using UnityEngine;

public class Inheritance : MonoBehaviour
{
   
   //THIS SCRIPT IS FOR PRACTICING INHERITANCE

}


public class Player
{
    
    //THIS CLASS IS FOR THE PLAYER//


    //SET UP SPME VARIABLES FOR THE PLAYER//
    public int Health = 100;

    public float MoveSpeed = 4.2f;

    public float JumpHeight = 3.5f;


    public GameObject PrimaryWeapon;


    //ALL CHILD CLASSES WILL INHERIT THIS FUNCTION AND DO THE LOGIC IN IT

    public void Attack()
    {
    

    }


    //IN ORDER TO MAKE CHILD CLASSES HAVE THEIR OWN VERSION
    public virtual void Attack2()
    {
        


    }




}

public class Tempest : Player
{


    //TEMPEST NOW INHERITS ALL VARIABLES IN PLAYER//

    // TEMPEST HAS ACCESS TO ATTACK(), BUT IT WILL DO WHAT THE CODE IN THE PARENT FUNCTION (PLAYER) DOES, INSTEAD OF ITS OWN BEHAVIOR


    public override void Attack2()
    {
        base.Attack();
    }


}




