using UnityEngine;

public class DirectionToTarget : MonoBehaviour
{

    public Transform target;

    Vector3 direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = transform.position - target.position;

        Debug.DrawLine(transform.position, target.position, Color.red); 
    }
}
