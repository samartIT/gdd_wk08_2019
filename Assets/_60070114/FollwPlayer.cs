﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    Vector3 offset = new Vector3(8, 4, -15);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
