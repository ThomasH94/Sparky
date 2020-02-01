using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is a tool to be attached to any object in the project so we can get a clear understanding
/// of the object without opening a bunch of scripts
/// </summary>
public class GameObjectNotes : MonoBehaviour
{
    [TextArea(1,10)]
    public string Notes;
}
