using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnee;
    public float timer = 2f;
    public float curTimer = 2f;
    float startTime;
    float timeDelay = 5f; // this is to decrease the spawning time over time
    public float minTime = 1.1f;
    public float enemySpawnRange = 50f;

    private void Start()
    {
        startTime = Time.time;

        for (int i = 0; i < 2; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-enemySpawnRange, enemySpawnRange), 2.06f, Random.Range(-enemySpawnRange, enemySpawnRange));
            Instantiate(spawnee, pos, Quaternion.identity);
        }
    }

    void Update()
    {
        curTimer -= Time.deltaTime;

        if (curTimer <= 0)
        {
            Vector3 pos = new Vector3(Random.Range(-enemySpawnRange, enemySpawnRange), 2.06f, Random.Range(-enemySpawnRange, enemySpawnRange));
            Instantiate(spawnee, pos, Quaternion.identity);
            curTimer = timer;
        }

        if ((Time.time - startTime) > timeDelay && timer >= minTime)
        {
            timeDelay += 5;
            timer -= 0.1f;
        }
    }
}
