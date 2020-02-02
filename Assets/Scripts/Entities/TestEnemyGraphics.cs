﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyGraphics : MonoBehaviour
{
    [SerializeField]
    private TestEnemyController controller;
    [SerializeField]
    private Animator anim;

    private void Update()
    {
        anim.SetBool("isWalking", controller.detectedPlayer);
    }
}
