using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothRotation : MonoBehaviour
{
     public GameObject follower;
    private Vector3 offset;
    public float speed = 3f;

    private void Start()
    {
       // follower = Camera.main.gameObject;
        offset = transform.position - follower.transform.position;
    }
    private void Update()
    {
        transform.position = follower.transform.position + offset;
        transform.rotation = Quaternion.Slerp(transform.rotation, follower.transform.rotation, speed*Time.deltaTime);
    }
}
