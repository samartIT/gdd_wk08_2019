using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinUpdate : MonoBehaviour
{
    public float speed = 50;
    public Vector3 rotationAxes = new Vector3(0, 1, 0);
    void Update()
    {
        transform.Rotate(rotationAxes, speed * Time.deltaTime);
    }
}
