using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject enemyLightPrefab;

    [HideInInspector]
    public GameObject enemyLight;

    public GameObject[] allEnemyLight;

    [HideInInspector]
    public UnityEvent NewEnemyCreated;

    [SerializeField]
    int enemiesAmount;

    void Start()
    {
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        enemyLight = Instantiate(enemyLightPrefab, transform.position + Vector3.right * 2, Quaternion.identity);
        NewEnemyCreated?.Invoke();
    }

}
