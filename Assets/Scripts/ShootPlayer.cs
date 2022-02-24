using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Start()
    {
        
    }

    void Update()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
