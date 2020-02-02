using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Dictionary<string, int> inventory;

    public void addItem(string item)
    {
        if (!inventory.ContainsKey(item))
        {
            inventory.Add(item, 0);
        }

        inventory[item]++;
    }
}
