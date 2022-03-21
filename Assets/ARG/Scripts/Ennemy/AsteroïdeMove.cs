using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroïdeMove : MonoBehaviour
{
    public float speed;
    
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
