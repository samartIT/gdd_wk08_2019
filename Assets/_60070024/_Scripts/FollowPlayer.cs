using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(17, 12, -33);
    void Update()
    {
        //transform.rotation = player.transform.rotation;
        transform.position = player.transform.position + offset;
    }
}
