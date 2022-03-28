using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public GameObject powerUp;
    public GameObject powerUpUI;
    public GameObject background;
    public GameObject[] heart;

    public bool backToThePast = false;
    public bool isRewinding = false;

    public int life;
    public int savePoint;

    List<Vector3> positions;



    void Start()
    {
        positions = new List<Vector3>();
    }

    private void FixedUpdate()
    {
        if (isRewinding == true)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Update()
    {
        if (life == 0)
        {
            if (backToThePast == true)
            {
                StartBonus();
            }
        }

        if (life == 2)
        {
            Destroy(heart[2].gameObject);
        }

        else if (life == 1)
        {
            Destroy(heart[1].gameObject);
        }

        else if (life == 0)
        {
            Destroy(heart[0].gameObject);
            //Destroy(gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PowerUp"))
        {
            powerUpUI.SetActive(true);
            backToThePast = true;
            Debug.Log("I'VE GOT THE POWER");
            powerUp.SetActive(false);
        }

        if (backToThePast == true)
        {
            Debug.Log("C'est termin�, ne bouge plus !");
        }

        if (collision.tag.Equals("Enemy"))
        {
            life = life - 1;
        }
    }

    private void Record()
    {
        positions.Insert(0, background.transform.position);
    }


    private void Rewind()
    {
        if (positions.Count > savePoint)
        {
            background.transform.position = positions[0];
            positions.RemoveAt(0);
            backToThePast = false;
        }
        else
        {
            StopBonus();
        }
    }
    
    private void StartBonus()
    {
        isRewinding = true;
        life = life + 1;
    }

    private void StopBonus()
    {
        isRewinding = false;
    }
}
