using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemscript : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
       PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
           playerInventory.ItemsCollected();
           gameObject.SetActive(false);
        }    }
}