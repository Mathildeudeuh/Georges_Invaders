using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AddVelocity))]
[RequireComponent(typeof(Mover))]
public class PlayerBehaviour : MonoBehaviour
{
    private Vector2 moveVector2;
    private Rigidbody2D rb2D;
    private AddVelocity addVelocity;
    [SerializeField] int currentHealth;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        addVelocity = GetComponent<AddVelocity>();
    }
    public void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        moveVector2 = obj.ReadValue<Vector2>();
        if (!obj.performed)
            return;
    }

    private void FixedUpdate()
    {
        addVelocity.Move2D(moveVector2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("blabla"))
        {
            currentHealth = currentHealth - 1;
        }
    }

}