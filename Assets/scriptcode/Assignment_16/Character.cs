using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Assignment16 {
public class  Character
{
    public string name ;
    private int health ;

    protected Position position;

    public int Health {

        get { return health; }
        set
        {
            if (value < 0)
                health = 0; // Minimum health is 0
            else if (value > 100)
                health = 100; // Maximum health is 100
            else
                health = value;
        }
    }

    public Character(string Name , int Health , Position Position ) {
     
     name = Name;
     this.Health = Health ;
     position = Position;
    }
    
    public Character() : this("No name", 100, new Position(0, 0, 0)) { }

    public virtual void DisplayInfo(){
         Debug.Log($" Name :{name} , Health = {health} ");
         position.printPosition();
    }

    public void Attack(int damage , Character target){
        target.health -= damage;
        Debug.Log($"{name} attacked {target.name} for {damage} damage.");
    }

    public void Attack(int damage , Character target , string attackType){
        Attack(damage , target);
        Debug.Log($" AttackType = {attackType}");
    }
}
} 
