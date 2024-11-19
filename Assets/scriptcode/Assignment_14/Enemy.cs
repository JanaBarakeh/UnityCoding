using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_14{
public class Enemy : Character
{

   public Enemy(string name, int health) : base(name, health) { }

   public void Attack(Character player , int amount){
    player.health -= amount;
     UnityEngine.Debug.Log($"{player.name} Attack by {name} . Current health: {player.health}");
  }
}
}
