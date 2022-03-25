using System.Collections;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public float shootDelay;
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
            yield return new WaitForSeconds(shootDelay);

        }
    }
    private void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
