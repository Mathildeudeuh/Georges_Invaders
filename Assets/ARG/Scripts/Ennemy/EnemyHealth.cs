using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int life = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBullet"))
        {
            life = life - 1;
        }
    }

    private void FixedUpdate()
    {
        if (life == 0)
            Destroy(gameObject);
    }

}
