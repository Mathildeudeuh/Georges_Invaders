using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] SOPlayerHealth currentHealthSO;
    //public int currentHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            //currentHealthSO.currentHealth -= currentHealthSO.currentHealth;
            currentHealthSO.currentHealth = currentHealthSO.currentHealth - 1;
        }
    }
}