using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI itemText; // Use Unity's UI Text class

    // Start is called before the first frame update
    void Start()
    {
        // Assuming that the Text component is on the same GameObject as this script
        itemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateitemText(PlayerInventory playerInventory)
    {
        itemText.text = playerInventory.NumberOfItems.ToString();
    }
}

