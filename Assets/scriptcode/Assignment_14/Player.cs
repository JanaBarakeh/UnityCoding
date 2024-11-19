using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_14{
public class Player : Character
{
   public Player(string name, int health) : base(name, health) { }

   public void Heal(int amount){
    health += amount;
    UnityEngine.Debug.Log($"{name} healed by {amount}. Current health: {health}");
  }
}
}
