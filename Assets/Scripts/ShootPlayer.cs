using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Start()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }

    void Update()
    {
    }
}
