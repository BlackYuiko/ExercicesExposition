using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
using static UnityEngine.UI.Image;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 12f;
    private Rigidbody2D rb;

    public float rayLength = 0.6f; 
    public LayerMask groundLayer;

        
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);
        
        return hit.collider != null;

    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // -1, 0 or 1
        rb.linearVelocity = new Vector2( horizontal * speed, rb.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

        Debug.DrawRay(transform.position, Vector2.down * rayLength, Color.red);

    }

    

}
