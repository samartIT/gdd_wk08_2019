using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(17, 12, -33);
    // Start is called before the first frame update
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
