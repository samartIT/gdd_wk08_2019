using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    public float driveSpeed = 30;
    public float trunSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float HoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * driveSpeed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * trunSpeed * HoHorizontal * Time.deltaTime);
    }
}
