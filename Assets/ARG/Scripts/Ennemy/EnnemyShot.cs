using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShot : MonoBehaviour
{
    private Rigidbody2D BulletPhysics;
    [SerializeField] private float Bulletspeed;
    
    void Awake()
    {
        BulletPhysics = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        BulletPhysics.AddForce(-transform.right * Bulletspeed);
    }
}
