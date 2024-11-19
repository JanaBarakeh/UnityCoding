using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_14{
public class GameManager : MonoBehaviour
{
    

    void Start()
    {
      Player player1= new Player("Subhi",120);
      Debug.Log($"Player Name = {player1.name}, Player Health = {player1.health}");

      Enemy enemy1= new Enemy("Zarifeh",60);
      Debug.Log($"Enemy Name = {enemy1.name}, Enemy Health = {enemy1.health}");

       player1.Heal(15);

       enemy1.Attack(player1, 30); 
        
    }

}
}
