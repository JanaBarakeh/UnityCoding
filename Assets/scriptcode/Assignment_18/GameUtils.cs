using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_18
{
public static class GameUtils 
{
     public static string DescribeItem<T>(T something){
        return $"This item is a {something}.";
     }
}
}
