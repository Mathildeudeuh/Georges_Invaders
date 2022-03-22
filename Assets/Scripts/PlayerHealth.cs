using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //[SerializeField] protected SOPlayerHealth currentHealthSO;
    public int currentHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            //currentHealthSO.currentHealth -= currentHealthSO.currentHealth;
            currentHealth = currentHealth - 1;
        }
    }
}