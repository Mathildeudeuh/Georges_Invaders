using UnityEngine;


public class ScrollerBackground : MonoBehaviour
{
    [SerializeField] private float speedX;
    
    void Update()
    {
        if (transform.position.x > 50)
        {
            transform.position += new Vector3(speedX * Time.deltaTime, 0);
        }
    }
}