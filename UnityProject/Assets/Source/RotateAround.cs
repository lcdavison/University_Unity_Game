﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Update is called once per frame
    void Update ( )
    {
        transform.LookAt ( Vector3.zero );
        transform.RotateAround ( Vector3.zero, Vector3.up, 20 * Time.deltaTime );
    }
}
