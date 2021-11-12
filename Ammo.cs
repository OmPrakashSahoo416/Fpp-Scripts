using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int currentAmmo = 30;
    //[SerializeField] float firingSpeed = 0.1f;

    void Start()
    {
        
    }

    public int GetCurrentAmmo()
    {
        currentAmmo--;
        return currentAmmo;
    }

}
