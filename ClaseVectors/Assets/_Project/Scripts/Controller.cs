using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour, InputSystem_Actions.IExpositionClassActions
{
    private InputSystem_Actions inputActions;

    public float speed = 5f;
    public float jumpForce = 12f;
    private Rigidbody2D rb;

    public float rayLength = 0.6f;
    public LayerMask groundLayer;

    private float horizontalInput;

    public void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.ExpositionClass.SetCallbacks(this);
    }
    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);

        return hit.collider != null;

    }

    
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocityY);

        Debug.DrawRay(transform.position, Vector2.down * rayLength, Color.red);

    }


    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded())
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // ReadValue<float>() lee el eje constantemente: 
        // -1 , 0 o 1
        horizontalInput = context.ReadValue<float>();
    }
}