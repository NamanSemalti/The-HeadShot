using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    [SerializeField] private Transform Camera;
    public static bool isRayCasting;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "PickUpBox")
        {

            
            RaycastHit hit;
            
            if (Physics.Raycast(Camera.position, Camera.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
               // Debug.Log(hit.transform.name);
                Debug.DrawRay(Camera.position, Camera.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if (hit.transform.tag == "PickupItems")
                {
                    isRayCasting = true;
                   
                }
                else
                {
                    isRayCasting = false;
                }
            }
        }
    }
}
