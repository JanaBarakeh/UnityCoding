using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_18{
public class GenericsTest : MonoBehaviour
{
      void Start()
    {
         GameContainer<string> game = new  GameContainer<string>();
         game.SetItem("Jana");

         string item = game.GetItem();
         Debug.Log($"Stored item: {item}");

         string DescribeItem = GameUtils.DescribeItem(item);
          Debug.Log(DescribeItem);
    }

}
}
