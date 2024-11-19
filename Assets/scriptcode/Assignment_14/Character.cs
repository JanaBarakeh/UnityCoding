using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_14{
public class Character 
{

    private string Name;
    private int Health;

    // getters and setters
    public string name{

     get {return Name;  }
     set {Name = value ;}

    }

    public int health
    {
        get { return Health; }
        set
        {
            if (value < 0)
                Health = 0; // Minimum health is 0
            else if (value > 100)
                Health = 100; // Maximum health is 100
            else
                Health = value;
        }
    }

    // constructor
    public Character(string Name, int Health)
    {
        name = Name;
        health = Health;
    }


}
}
