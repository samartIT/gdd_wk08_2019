using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float driveSpeed = 30;
    public float turnSpeed = 90f;


    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*driveSpeed*verticalInput*Time.deltaTime);
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
    }
}
