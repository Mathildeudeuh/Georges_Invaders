using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AddVelocity))]
[RequireComponent(typeof(Mover))]
public class PlayerBehaviour : MonoBehaviour
{
    private Vector2 moveVector2;
    private Rigidbody2D rb2D;
    private AddVelocity addVelocity;
    //private PowerUp powerUp;
    //private GameObject scroll;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        addVelocity = GetComponent<AddVelocity>();
        //powerUp = GetComponent<PowerUp>();
    }
    public void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        moveVector2 = obj.ReadValue<Vector2>();
        if (!obj.performed)
            return;
    }

    /*
    public void PowerOnPerformed(InputAction.CallbackContext obj)
    {
        if (powerUp.backToThePast == true)
        {
            scroll.transform.position + new Vector3(20, 0, 0);
        }
    }*/

    private void FixedUpdate()
    {
        addVelocity.Move2D(moveVector2);
    }
}