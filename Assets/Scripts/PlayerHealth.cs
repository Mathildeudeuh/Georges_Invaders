using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private SOPlayerHealth currentHealthSO;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("blabla"))
        {
            currentHealthSO.currentHealth = currentHealthSO.currentHealth - 1;
        }
    }
}
