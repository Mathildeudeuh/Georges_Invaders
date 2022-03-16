using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCanon : MonoBehaviour
{
    public GameObject bullet;
    public float shotDelay;
    bool isRunning;
    public float canonAngle;
    void Awake()
    {
        StartCoroutine(Shoot());
        transform.Rotate(0, 0, canonAngle);
    }

    void FixedUpdate()
    {
        
    }

    private IEnumerator Shoot()
    {
        isRunning = true;
        while (isRunning)
        {
            yield return new WaitForSeconds(shotDelay);
            Instantiate(bullet, transform.position, transform.rotation);
            
        }
    }
}
