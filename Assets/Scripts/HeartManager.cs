using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public GameObject[] heart;
    private PlayerHealth playerHealth;
    public int life;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            //currentHealthSO.currentHealth -= currentHealthSO.currentHealth;
            life = life - 1; 
        }
        if (collision.tag.Equals("enemyBullet"))
        {
            life = life - 1;
        }
    }
    private void Update()
    {
        /*
        if (playerHealth.currentHealth <= 2)
        {
            Destroy(heart[2].gameObject);
        }

        if (playerHealth.currentHealth <= 1)
        {
            Destroy(heart[1].gameObject);
        }

        if (playerHealth.currentHealth <= 0)
        {
            Destroy(heart[0].gameObject);
        }*/

        if (life == 2)
        {
            Destroy(heart[2].gameObject);
        }

        else if (life == 1)
        {
            Destroy(heart[1].gameObject);
        }

        else if (life <= 0)
        {
            Destroy(heart[0].gameObject);
            Destroy(gameObject);
        }
    }
}