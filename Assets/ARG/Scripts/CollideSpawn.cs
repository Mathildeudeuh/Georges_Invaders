using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Spawner))]
public class CollideSpawn : MonoBehaviour
{
    private Spawner spawner;
    void Awake()
    {
        spawner = GetComponent<Spawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spawner.StartSpawn();
            //Debug.Log("hit1");
        }
    }
}
