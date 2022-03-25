using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public GameObject powerUpUI;
    public bool backToThePast;

    private void Start()
    {
        backToThePast = false;
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag.Equals("Player"))
        {
            powerUpUI.SetActive(true);
            backToThePast = true;
            Debug.Log("I'VE GOT THE POWER");
            powerUp.SetActive(false);
        }

        if (backToThePast == true)
        {
            Debug.Log("C'est terminé, ne bouge plus !");
        }
    }
}
