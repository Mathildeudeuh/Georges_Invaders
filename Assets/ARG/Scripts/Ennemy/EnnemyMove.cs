using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed;
    private  Rigidbody2D ennemyBody2D;
    
    void Awake()
    {
        
        
    }

    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x -= speed * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
