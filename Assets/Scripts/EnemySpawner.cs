using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] float timeBetweenSpawns;
    float timeElapsed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > timeBetweenSpawns)
        {
            SpawnShip();
            timeElapsed = 0;
        }
    }
    void SpawnShip()
    {
        int rx = Random.Range(-8, 9);
        Vector3 position = new Vector3(rx, 7, 0);
        Instantiate(EnemyPrefab, position,
          Quaternion.identity);
    }
}
