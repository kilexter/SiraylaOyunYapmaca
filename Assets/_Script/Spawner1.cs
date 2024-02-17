using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    [System.Serializable]
    public struct EnemySpawnData
    {
        public GameObject enemyPrefab;
        [Range(0, 100)] public int spawnProbability;
    }

    public List<EnemySpawnData> enemySpawnDatas = new List<EnemySpawnData>();

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    void SpawnEnemy()
    {
        int randomValue = Random.Range(0, 101);

        foreach (EnemySpawnData spawnData in enemySpawnDatas)
        {
            if (randomValue < spawnData.spawnProbability)
            {
                Instantiate(spawnData.enemyPrefab, transform.position, Quaternion.identity);
                return;
            }
        }
    }
    
}
