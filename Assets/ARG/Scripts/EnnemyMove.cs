using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed;
    private new Rigidbody2D ennemyBody2D;

    void Awake()
    {
        ennemyBody2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        ennemyBody2D.velocity = new Vector2(speed, 0 );
    }
}
