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
        float HorizonInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * driveSpeed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * HorizonInput * Time.deltaTime);
    }
}
