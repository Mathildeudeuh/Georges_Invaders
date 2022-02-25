using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    protected Rigidbody2D rb2D;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public abstract void Move2D(Vector2 moveVector2);
}