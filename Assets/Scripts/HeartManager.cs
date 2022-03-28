using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public GameObject[] heart;
    public int life;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            life = life - 1; 
        }
        if (collision.tag.Equals("enemyBullet"))
        {
            life = life - 1;
        }
    }
    private void Update()
    {
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
            //Destroy(gameObject);
           
        }
    }
}