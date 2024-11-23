using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{

 public class Soldier :  Character   {
    public Soldier(string Name , int Health , Position Position) : base(Name, Health , Position) { }
  

     public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }

}

public class Officer :  Character
{
    public Officer(string Name , int Health , Position Position) : base(Name, Health , Position) { }
  
     public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
}

}

