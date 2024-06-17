using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPoints = new Transform[8];
    public GameObject[] enemyTypes = new GameObject[8];
    public List<GameObject> enemies = new List<GameObject>();

    public GameObject player;

    void Start()
    {
        SpawnEnemies();
    }

    void Update()
    {
        
    }

    void PrintNums()
    {
        for (int i = 1; i < 101; i++)
            Debug.Log(i);
    }

    void SumFist10NaturalNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
            sum += i;

        Debug.Log(sum);
    }

    void SumNaturalNumbers(int targetNums)
    {
        int sum = 0;
        for (int i = 1; i <= targetNums; i++)
            sum += i;

        Debug.Log(sum);
    }

    void SpawnEnemies()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            int rNum = Random.Range(0, enemyTypes.Length);
            GameObject e = Instantiate(enemyTypes[rNum], spawnPoints[i].position, spawnPoints[i].rotation);
            enemies.Add(e);
        }

        Debug.Log($"Enemy Count: {enemies.Count}");
    }

    GameObject FindClosestEnemyToPlayer()
    {
        GameObject closestEnemy = null;
        float bestDistance = float.MaxValue;

        for(int i = 0; i < enemies.Count; i++)
        {
            float distance = Vector3.Distance(player.transform.position, enemies[i].transform.position);
            if(distance < bestDistance)
            {
                bestDistance = distance;
                closestEnemy = enemies[i];
            }
        }

        return closestEnemy;
    }
}
