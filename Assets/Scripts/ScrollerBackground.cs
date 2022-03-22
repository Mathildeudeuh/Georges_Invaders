using UnityEngine;

public class ScrollerBackground : MonoBehaviour
{
    [SerializeField] private float speedX;


    void Update()
    {
        transform.position += new Vector3(speedX * Time.deltaTime, 0);
    }
}
