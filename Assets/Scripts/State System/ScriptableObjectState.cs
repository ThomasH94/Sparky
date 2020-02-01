using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will serve as a way of creating Scriptable Object Based States
/// This is to better compare states instead of using Enums to be more flexible and use more information
/// We can also add/remove states without breakage
/// </summary>

[CreateAssetMenu(fileName = "New State", menuName = "Scriptable Objects/States")]
public class ScriptableObjectState : ScriptableObject
{

}
