using UnityEngine;

public class SmartTurrret : MonoBehaviour
{
    public Transform target;
    public float visionRange = 30f;
    public LayerMask visionMask;

    private SpriteRenderer spriteRenderer;

    float angle;

        

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange, visionMask);

        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            spriteRenderer.color = Color.red;
            transform.eulerAngles = new Vector3(0, 0, angle);
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

}
