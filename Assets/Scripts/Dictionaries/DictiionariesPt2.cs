using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DictiionariesPt2 : MonoBehaviour
{
   
    //THIS SCRIPT IS A REFRESHER OF HOW DICTIOANRIES WORK//

    
     private Dictionary<string, bool> Quests = new Dictionary<string, bool>();


    [Header("Ui Info")]
    public Slider HealthSlider;

   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Quests.Add("KILL THE OGRE", false);

        Quests.Add("FIND DIAMOND", false);


        //USING FOR EACH WITH DICTIONARIES//
        foreach(KeyValuePair<string, bool> slot in Quests)
        {
            




        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
