#pragma warning disable 649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;

#pragma warning restore  649

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }

}
