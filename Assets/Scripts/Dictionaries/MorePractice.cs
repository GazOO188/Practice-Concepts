using System;
using System.Collections.Generic;
using UnityEngine;

public class MorePractice : MonoBehaviour
{
    //MORE PRACTICE USING DICTIONARIES AND ENUMS//


    //ENUMS//


    //THIS ENUM IS FOR STATUS EFFECTS OR SUBCLASSES//
    public enum StatusEffects
    {
        Void,
        
        Arc,

        Solar,

        Stasis,

        Strand,

        Prismatic,



    }


    public enum ElementEffects
    {
        
        Devour,

        Radiant,

        Slowed,

        Scorched,

        Jolted,

        Severed,
    
    
    
 
    
    }


    //DICTIONARY THAT COMBINES ENUMS//



    private Dictionary<StatusEffects, float> DamageSubclass = new Dictionary<StatusEffects, float>();



    //DICTIONARY THAT MERGES THE TWO ENUMS//


    private Dictionary<StatusEffects, ElementEffects> ElementalEffects = new Dictionary<StatusEffects, ElementEffects>();



    //DEVOUR ABILITIES//


    public float HealAmount, playerHealth;

   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        ElementalEffects.Add(StatusEffects.Void, ElementEffects.Devour);

        ElementalEffects.Add(StatusEffects.Solar, ElementEffects.Radiant);

        ElementalEffects.Add(StatusEffects.Arc, ElementEffects.Jolted);

        ElementalEffects.Add(StatusEffects.Stasis, ElementEffects.Slowed);

        ElementalEffects.Add(StatusEffects.Strand, ElementEffects.Severed);
    
    
    
    }

   
   
   
    // Update is called once per frame
    void Update()
    {
        
        //FOREACH LOOP FOR DAMAGESUBCLASS//

        //EFFECTS -> THIS IS A TEMPORARY VARIABLE IN THE FOREACH LOOP THAT TAKES THE VALUE OF EACH KEY IN DICTIONARY/LOOP//


        //FIRST LOOP: EFFECTS == VOID//

        //SECOND LOOP: EFFECTS == ARC//

        //THIRD LOOP: EFFECTS == SOLAR//


        // THIS FOR EACH LOOP FOR GIVES ARC A 80 PERCENT DAMAGE BUFF, WHILE EVERY OTHER DAMAGE BUFF GETS A 50% DAMAGE BUFF//
        foreach(StatusEffects Effects in DamageSubclass.Keys)
        {
        


            //EFFECTS IS THE KEY CURRENTLY IN THE LOOP(ARC,VOID,SOLAR)//


            //EFFECTS IS A ENUM VALUE LIKE (VOID, ARC, SOLAR)

            if(Effects == StatusEffects.Arc)
            {

            
            //DamageSubclass[Effects] -> GETS THE NUMBER FOR THIS EFFECT AND GIVES IT A 80% DAMAGE BUFF//

            //ONLY THE ARC SUBLCASS GETS A 80% DAMAGEBUFF
                
            DamageSubclass[Effects] *= 1.8f; 
                
            
           
            }


            

            else
            {
                
            //THIS GIVES ALL STATUS EFFECT A 50% DAMAGE BUFF//
            DamageSubclass[Effects] = DamageSubclass[Effects] * 1.5f;
            
            }





        
        
        }



        //PRACTICE WITH THE TWO ENUMS//


        //ELEMENTAL EFFECTS.KEY GIVES THE LEFT VALUE OF THE DICTIONARY//

        //THIS IS SAYING FOREACH STATUS EFFECT KEY IN ELEMENTALEFFECTS.KEYS

        foreach(StatusEffects SE in ElementalEffects.Keys)
        {
            
            
            //THIS LINE GETS THE VALUE FOR THE KEYS IN THE FOREACH LOOP

            //GETS THE VALUE OF THE SPECIFIC STATUSEFFECT LIKE: VOID, ARC//
            ElementEffects effect = ElementalEffects[SE];


            //IF THE EFFECT IS DEVOUR, THEN HEAL THE PLAYER BY THE AMOUNT//
            if(effect == ElementEffects.Devour)
            {

                playerHealth = HealAmount;
            
            
            }
        
        
        }



    
    
    
    }






}
