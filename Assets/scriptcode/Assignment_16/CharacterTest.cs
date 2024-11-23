using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment16;

public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character[] characters = new Character[2];
        characters[0] = new Soldier("jana" ,-1 , new Position(1,1,1));
        characters[1] = new Officer("Barakeh" , 110, new Position(2,2,2)); 
        
         foreach (var character in characters)
        {
            character.DisplayInfo();
        }
        
        Soldier soldier = (Soldier)characters[0];
        Officer officer = (Officer)characters[1];

        Debug.Log($"Soldier Health before attack: {soldier.Health}");
        officer.Attack(20, soldier, "shooting");
        Debug.Log($"Soldier Health after attack: {soldier.Health}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
