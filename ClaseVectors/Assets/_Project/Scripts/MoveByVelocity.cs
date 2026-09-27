using UnityEngine;

public class MoveByVelocity : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    float speed = 3;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity =
            new Vector2(speed, 0f);


    }
}
