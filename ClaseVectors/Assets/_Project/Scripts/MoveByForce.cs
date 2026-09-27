using UnityEngine;
using UnityEngine.Rendering;

public class MoveByForce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    float force = 3;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(
            new Vector2(force, 0f));


    }
}
