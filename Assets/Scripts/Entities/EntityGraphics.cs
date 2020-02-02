using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGraphics : MonoBehaviour
{
    [SerializeField]
    protected EntityController controller;

    protected virtual void Start()
    {
        //controller.onFacingDirectionUpdated += UpdateFacingDirection;
    }

    //protected virtual void UpdateFacingDirection(FacingDirection newDir) { }
}
