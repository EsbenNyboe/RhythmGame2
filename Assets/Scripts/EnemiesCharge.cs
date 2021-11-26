using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[RequireComponent(typeof(EnemiesSpawn))]
public class EnemiesCharge : MonoBehaviour
{
    EnemiesSpawn enemiesSpawn;

    MoveTowardsPlayer moveTowardsPlayer;


    void Awake()
    {
        enemiesSpawn = GetComponent<EnemiesSpawn>();
        enemiesSpawn.NewEnemyCreated.AddListener(StoreComponent);
    }

    void StoreComponent()
    {
        moveTowardsPlayer = enemiesSpawn.enemyLight.GetComponent<MoveTowardsPlayer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveTowardsPlayer.BeginMoving();
        }
    }
}
