using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private Dictionary<RobotPartType, int> _inventory = new Dictionary<RobotPartType, int>();
    public Dictionary<RobotPartType, int> Inventory {
        get => _inventory;
    }

    public void addItem(RobotPartType item)
    {
        if (!_inventory.ContainsKey(item))
        {
            _inventory.Add(item, 0);
        }

        _inventory[item]++;

        Debug.Log($"picked up {item.ToString()}. total: {_inventory[item]}");
    }
}
