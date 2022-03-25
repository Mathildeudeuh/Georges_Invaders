using UnityEngine;

public class ScrollerBackground : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float pos;
    private PowerUp powerUp;
    //private HeartManager heartManager;

    private void Start()
    {
        powerUp = GetComponent<PowerUp>();
        //heartManager = GetComponent<HeartManager>();
    }

    void Update()
    {
        if (transform.position.x > pos)
        {
            transform.position += new Vector3(speedX * Time.deltaTime, 0);
        }
    }
}