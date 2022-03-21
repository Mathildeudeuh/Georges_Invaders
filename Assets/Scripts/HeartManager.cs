using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public GameObject heart;
    private PlayerHealth playerHealth;

    private void Start()
    {
        var player = GameObject.FindWithTag("player");
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void UpdateHeart(int heartNumber)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Pour le premier �l�ment et tant que le nombre d'�l�ments n'est pas �gale � celui des coeurs, on ajoute un �l�ment
        for (var i = 0; i < heartNumber; i++)
        {
            Instantiate(heart, Vector3.zero, Quaternion.identity, transform);
        }
    }

    private void Update()
    {
        UpdateHeart(playerHealth.currentHealth);
    }
}