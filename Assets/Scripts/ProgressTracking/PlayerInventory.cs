using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    public void addItem(string item)
    {
        if (!inventory.ContainsKey(item))
        {
            inventory.Add(item, 0);
        }

        inventory[item]++;
    }


}
