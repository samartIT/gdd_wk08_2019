﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float driveSpeed = 30;
    public float turnSpeed = 90f;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * driveSpeed * verticalInput * Time.deltaTime);
        transform.Rotate(0, horizontalInput * turnSpeed * Time.deltaTime,0);
    }
}
