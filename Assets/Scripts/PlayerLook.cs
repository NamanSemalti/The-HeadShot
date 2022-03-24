using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform camera;
    [SerializeField] private Transform Player;
    void Update()
    {
        //transform.position = Player.position;
        transform.rotation = camera.rotation;
    }
}
