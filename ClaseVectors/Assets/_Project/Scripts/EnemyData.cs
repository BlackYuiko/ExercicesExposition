using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Game/Enemy Data")]

public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int maxHealth;
    public int damage;
	public float speed;
	public Color color;

}
