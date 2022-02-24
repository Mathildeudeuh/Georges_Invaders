using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Start()
    {
        Shoot();
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    private void FixedUpdate()
    {
        Shoot();
    }
    void Update()
    {

    }
}
