using UnityEngine;


public class ScrollerBackground : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float pos; 
    
    void Update()
    {
        if (transform.position.x > pos)
        {
            transform.position += new Vector3(speedX * Time.deltaTime, 0);
        }
    }
}