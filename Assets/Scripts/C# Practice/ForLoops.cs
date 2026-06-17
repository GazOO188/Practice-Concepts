using UnityEngine;

public class ForLoops : MonoBehaviour
{
    //THIS SCRIPT IS FOR PRACTICING LOOPS//


    [SerializeField] public GameObject Oracle;


    //TYPES OF LOOPS//

    //1) WHILE LOOP
    //2) FOR LOOP
    //3) FOREACH LOOP
    //4) DO-WHILE LOOP


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // SpawnOracles(Oracle);



        //WHILE LOOPS//
        int itemCount = 5;


        //while(itemCount > 0)
        //{
            
           // SpawnOracles(Oracle);

          //  itemCount--;

       // }


        //DO WHILE//


        //do
       // {
           // SpawnOracles(Oracle);
           // itemCount--;
       // }
       // while(itemCount > 0);



        //FOR LOOP//


        //PARAMETERS OF FOR LOOP:

        //1) WHERE YOU WANT TO START FROM//
        
        //2) CONDITION

        //3) INCREMENT


        //DECREMENT VERSION
        for(int i = itemCount; i > 0; i--)
        {
            

           // SpawnOracles(Oracle);



        }


        //INCREMENT VERSION//

        //GOES UP TO 5//

        for(int i = 1; i <= 5; i++)
        {
            
           // SpawnOracles(Oracle);


        }


        //GOES UP TO 3//


        for(int i = 0; i<4; i++)
        {
            

            SpawnOracles(Oracle);


        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //FUNCTION FOR SPAWNING ORACLE//


    void SpawnOracles(GameObject Oracle)
    {
        

        Instantiate(Oracle, new Vector3(0,0,0), Quaternion.identity);



    }
}
