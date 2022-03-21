using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] protected SOPlayerHealth currentHealthSO;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("blabla"))
        {
            currentHealthSO.currentHealth -= currentHealthSO.currentHealth;
        }
    }
}