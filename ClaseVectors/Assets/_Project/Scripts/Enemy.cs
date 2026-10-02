using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData[] data;
    private int currentHealth;
    private EnemyData currentData;

	private void Start()
    {
		currentData = data[Random.Range(0,data.Length)];
        GetComponent<SpriteRenderer>().color = currentData.color;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * currentData.speed * Time.deltaTime);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
