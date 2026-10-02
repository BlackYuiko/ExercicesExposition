using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private float spawnInterval = 3f;

    private float timer;
    
    private void Update() 
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            Vector3 position = transform.position;
            GameObject newObject = pool.GetObject(position);
            newObject.GetComponent<TimedObject>().SetPool(pool);
        }
    }
}
