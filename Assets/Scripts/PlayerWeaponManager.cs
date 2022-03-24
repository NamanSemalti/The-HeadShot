using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject[] PlayerWeapons;
    private void Start()
    {
        
    }
    private void Update()
    {
        PlayerWeapons[ItemPickup.currentWeaponIndex].SetActive(true);
    }
}
