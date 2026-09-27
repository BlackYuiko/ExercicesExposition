using UnityEngine;
using UnityEngine.UIElements;

public class TurretAim : MonoBehaviour
{

    public Transform target;

    Vector3 direction;

    float angle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = transform.position - target.position;

        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0, 0, angle);
	}
}
