using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float MoveSpeed = 3;
    Rigidbody2D rb;
    Vector2 moveInput;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        rb.linearVelocity = moveInput * MoveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
