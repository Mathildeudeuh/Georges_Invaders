using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootPlayer : MonoBehaviour
{
    public float shotDelay;
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
            yield return new WaitForSeconds(shotDelay);

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
