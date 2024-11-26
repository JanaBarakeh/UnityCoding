using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_18{
public class Inventory 
{
   private List<string> list ;

   public Inventory (){
    list = new List<string>();
   }

   public void AddItem(string item){
    list.Add(item);
   }

   public void  ShowItems(){
    foreach (string item in list )
    {
        Debug.Log(item);
    }
   }

    public static Inventory operator +(Inventory a, Inventory b)
        {
           Inventory combine = new Inventory();
           combine.list.AddRange(a.list);
           combine.list.AddRange(b.list);
           return combine ;
        }
}
}
