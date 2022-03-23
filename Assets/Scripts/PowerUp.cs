using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public GameObject powerUpUI;
    public bool backToThePast;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag.Equals("Player"))
        {
            powerUpUI.SetActive(true);
            backToThePast = true;
            Debug.Log("I'VE GOT THE POWER");
            powerUp.SetActive(false);
        }
    }
}
