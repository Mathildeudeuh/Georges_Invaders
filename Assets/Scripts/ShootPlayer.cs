using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Start()
    {
        StartCoroutine(Shooting());
    }

    private IEnumerator Shooting()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(0.3f);

        }
    }
    private void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {

    }
}
