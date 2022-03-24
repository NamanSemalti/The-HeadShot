using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private GameObject Weapon;
    [SerializeField] private GameObject WeaponWithPlayer;
    [SerializeField] private GameObject Torch;
    public static int currentWeaponIndex;
    
    private void Start()
    {
        currentWeaponIndex = 0;
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("PlayerEntered");
            if (Input.GetKeyDown(KeyCode.F) && PlayerRayCast.isRayCasting)
            {
                Destroy(Weapon.gameObject);
                Torch.SetActive(false);
                WeaponWithPlayer.SetActive(true);
                
            }
        }
    }

    
    
}
