using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(2, 2, -4);
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
