using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_18{
public class GameInventory : MonoBehaviour
{

    void Start()
    {
        Inventory potions = new Inventory();
        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");

        Inventory elixirs= new Inventory();
        potions.AddItem("Elixir");
        potions.AddItem("Dark Elixir");

        Inventory combine = potions + elixirs ;

        Debug.Log("Combined Inventory Items:");
        combine.ShowItems();


        
    }

}
}