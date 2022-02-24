using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector2 move;
    private Rigidbody2D rb2D;



    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    public void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        move = obj.ReadValue<Vector2>();
        if (!obj.performed)
            return;
    }

    void Update()
    {
        
    }
}
