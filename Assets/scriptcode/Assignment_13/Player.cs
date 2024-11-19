using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   
   public string playerName;
   public int health;
   
   private static int playerCount = 0 ;

   public void InitializePlayer(string name, int initialHealth){
    playerName=name;
    health = initialHealth;
    playerCount++;
   }

   public void Heal(int amount){
    health+=amount;
    Debug.Log($"{playerName} healed by {amount}. Current health: {health}");
   }

   public void Heal(bool fullRestore){
    
      if (fullRestore) // if true
        {
            health = 200; // Assuming full health is 500
            Debug.Log($"{playerName} fully restored. Current health: {health}");
        }
   }

   public void ShowPlayerCount(){

    Debug.Log($" total count {playerCount}");
   }

}
