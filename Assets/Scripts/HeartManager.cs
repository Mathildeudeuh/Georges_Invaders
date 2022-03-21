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

        // Pour le premier élément et tant que le nombre d'éléments n'est pas égale à celui des coeurs, on ajoute un élément
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