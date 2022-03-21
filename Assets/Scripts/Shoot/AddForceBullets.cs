using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBullets : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] public Vector2 direction;
    [SerializeField] public float speed;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2D.velocity = direction.normalized * speed;
    }
}