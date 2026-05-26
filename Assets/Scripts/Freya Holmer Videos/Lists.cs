using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    //THIS SCRIPT IS FOR PRACTICING LISTS//


    //SETTING/DECLARING A LIST OF TYPE GAMEOBJECT//
    public List<GameObject> Oracles = new List<GameObject>();

   
    //THIS LIST IS TO TRACK THE ORDER OF THE ORACLES THE PLAYER SHOT//
    public List<GameObject>TrackOracleOrder = new List<GameObject>();


    //THE ORACLES TO SPAWN//
    public GameObject LeftOracles, MiddleOracle, RightOracle;


    //BOOLS//

    public bool OracleDestoryed = false, canSpawnOracle = true;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //THIS ADDS THE ORACLES TO THE LIST//
        Oracles.Add(LeftOracles);

        Oracles.Add(MiddleOracle);
        
        Oracles.Add(RightOracle);




        StartCoroutine(SpawnOracles());


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //THIS FUNCTION CHECKS WHICH ORACLE WAS SHOT AT IN THE LIST. THE ORACLE SHOT AT IS IN THE PARAMETER
    public void AddOraclestoManager(GameObject OracleShotat)
    {


        //THIS CHECKS IF THE GAMEOBJECT IN THE PARAMETER IS IN THE LIST NAMED ORACLES
        if (Oracles.Contains(OracleShotat))
        {
            
            //ADD IT TO THE TRACKORACLEORDER LIST//
            TrackOracleOrder.Add(OracleShotat);
       
       
       
       
        }
   
   
    }

    //EXAMPLE OF HOW THIS RUNS:

        
    //NOTES:

    // USE FOR LOOP WHEN THE INDEX MATTERS// 
    // USE FOREACH WHEN THE ITEM ITSELF IS ALL YOU NEED//
   
    public IEnumerator SpawnOracles()
    {
      
      foreach(GameObject AetheonOracles in Oracles)
      {
            
       GameObject Aetheon = Instantiate(AetheonOracles, transform.position, Quaternion.identity);

       Oracles.Add(Aetheon);

       yield return new WaitForSeconds(1.3f);

       
       
      }
    
    
    }
   
   
   
    }



