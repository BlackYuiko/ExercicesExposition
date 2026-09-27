using UnityEngine;

public class MoveByPosition : MonoBehaviour
{
    float speed = 3;

	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement =
            new Vector3(speed, 0f, 0f);
        transform.position +=
            movement * Time.deltaTime;


    }
}
