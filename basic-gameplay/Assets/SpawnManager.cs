using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private const float MinX = -9.0f;
    private const float MaxX = 9.0f;
    private const float MinZ = 4.0f;
    private const float MaxZ = 12.0f;
    private const float PositionY = 1.38f;
    private const float StartDelay = 1.0f;
    private const float EnemySpawnRepeatTime = 1.0f;
    private const float PowerupSpawnRepeatTime = 5.0f;

    public GameObject[] enemies;
    public GameObject powerup;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", StartDelay, EnemySpawnRepeatTime);
        InvokeRepeating("SpawnPowerup", StartDelay, PowerupSpawnRepeatTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnRandomEnemy()
    {
        var randomIndex = Random.Range(0, this.enemies.Length - 1);
        var randomEnemy = this.enemies[randomIndex];
        Instantiate(randomEnemy, this.GenerateRandomPosition(), randomEnemy.gameObject.transform.rotation);
    }

    private void SpawnPowerup()
    {
        Instantiate(this.powerup, this.GenerateRandomPosition(), this.powerup.transform.rotation);
    }

    private Vector3 GenerateRandomPosition()
    {
        var randomX = Random.Range(MinX, MaxX);
        var randomZ = Random.Range(MinZ, MaxZ);

        return new Vector3(randomX, PositionY, randomZ);
    }
}
