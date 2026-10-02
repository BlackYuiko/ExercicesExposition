using System.Runtime.CompilerServices;
using UnityEngine;

public class TimedObject : MonoBehaviour
{
	[SerializeField] private float lifeTime = 3f;

	private ObjectPool pool;
	private float timer;
	private void OnEnable()
	{
		timer = 0;
	}
	public void SetPool(ObjectPool newPool)
	{
		pool = newPool;
	}

    private void Update()
    {
		timer += Time.deltaTime;

		if (timer > lifeTime) 
		{
			pool.ReturnObject(gameObject);
		}
    }
}
