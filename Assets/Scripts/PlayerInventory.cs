using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfItems { get; private set; }
   public void ItemsCollected()
   {
    NumberOfItems++;
   }
  
}