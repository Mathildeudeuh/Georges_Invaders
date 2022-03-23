using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2.2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }

    }
}
