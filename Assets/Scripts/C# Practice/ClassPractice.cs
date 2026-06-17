using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    // INPUT + GAME LOOP LAYER (MonoBehaviour ONLY HERE)

    public Player P1;

    void Start()
    {
        P1 = new Player(100, 200);
    }

    void Update()
    {
        // INPUT BELONGS HERE (NOT IN PLAYER CLASS)

        if (Input.GetKeyDown(KeyCode.E))
        {
           P1.EquipWeapon(WeaponType.Shotgun);
        }
    }

    // WEAPON TYPE 
    public enum WeaponType
    {
        Shotgun,
        AssaultRifle
    }

    // PLAYER CLASS 
    public class Player
    {

        //FIELDS//
        public int health;
        public int maxHealth = 100;

        public WeaponType currentWeapon;


        //CONSTRUCTOR//
        public Player(int startingHealth, int Max)
        {
            health = startingHealth;

            Max = maxHealth;
            
        }

        // HEAL AMOUNT
        public void Heal(int amount)
        {

            //ADD HEALTH AMOUNT//
            health += amount;

            //CLAMP HEALTH SO IT DOSEN'T GO OVER 100//
            health = Mathf.Clamp(health, 0, maxHealth);
        }


        // TAKE DAMAGE
        public void TakeDamage(int damage)
        {
            health -= damage;
            health = Mathf.Clamp(health, 0, maxHealth);


            //IF HEALTH IS BELOW 0, PLAYER DIES//
            if (health <= 0)
            {
                Die();
            }
        }

        // EQUIP WEAPON 
        public void EquipWeapon(WeaponType weapon)
        {

            //THIS LINE IS IMPORTANT SO THE CODE BELOW CAN WORK IF IT'S SET TO A SPECFIC STATE//
            currentWeapon = weapon;

            switch (weapon)
            {
                case WeaponType.Shotgun:
                {
                        
                    Debug.Log("Equipped Shotgun");
                    break;

                }

                case WeaponType.AssaultRifle:
                {
                        

                    Debug.Log("Equipped Assault Rifle");
                    break;

                }
            }
        }

        public void Die()
        {
            Debug.Log("Player died");
        }
    }
}