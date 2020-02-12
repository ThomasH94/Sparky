using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryDictionary : Dictionary<RobotPartType, int>
{
    public void addItem(RobotPartType item)
    {
        if (!ContainsKey(item))
        {
            Add(item, 0);
        } 

        this[item]++;
    }
}
