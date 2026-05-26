using UnityEngine;

public class GridsPractice : MonoBehaviour
{
    //THIS SCRIPT IS FOR MAKING GRIDS USING 2 FOR LOOPS//

    public GameObject Floors;

    public int Width, Length;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       MakeGrid(); 
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MakeGrid()
    {
        
        //THIS FUNCTION MAKES A 3 BY 3 GRID//

        for(int x = 0; x < 4; x++)
        {
            
            for(int Z = 0; Z < 4; Z++)
            {
                
                Vector3 Locations = new Vector3(x * Width, 0, Z * Length);

                Instantiate(Floors, Locations, Quaternion.identity);
            
            
            }
       
       
       
       
        }
    
    
    
    
    }


}
