﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoitLightMovement : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        transform.position = target.transform.position;
    }
}
