using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl: MonoBehaviour
{
    public float driveSpeed = 30;
    public float turnSpeed = 90f;
    // Start is called before the first frame update
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * driveSpeed * verticalInput * Time.deltaTime);
        
    }
}
