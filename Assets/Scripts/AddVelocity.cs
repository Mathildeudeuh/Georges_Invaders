using UnityEngine;

public class AddVelocity : Mover
{
    [SerializeField] Vector2 maxSpeed;
    public override void Move2D(Vector2 moveVector2)
    {
        if (rb2D.velocity.x < maxSpeed.x)
        {
            rb2D.velocity = maxSpeed * moveVector2;
        }

        if (rb2D.velocity.y < maxSpeed.y)
        {
            rb2D.velocity = maxSpeed * moveVector2;
        }
    }
}