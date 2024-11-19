using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     Player player1= new Player();
        Player player2= new Player();
    void Start()
    {

        player1.InitializePlayer("barakeh",50);
        player2.InitializePlayer("jana",100);

        player1.Heal(50);
        player2.Heal(true);

        player1.ShowPlayerCount();
        player2.ShowPlayerCount();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
