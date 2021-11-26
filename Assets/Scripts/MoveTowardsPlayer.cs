using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;

    [SerializeField]
    float timeToCharge = 1f;

    IEnumerator chargeProcess;

    float timer;
    Vector2 targetFixedPosition;

    public void BeginMoving()
    {
        StopAllCoroutines();
        chargeProcess = ChargeProcess();
        StartCoroutine(chargeProcess);
    }

    IEnumerator ChargeProcess()
    {
        timer = 0;

        targetFixedPosition = PlayerPositionTag.playerPositionReadOnly;

        while (timer < timeToCharge)
        {
            Move();
            timer += Time.deltaTime;
            yield return null;
        }
    }

    void Move()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, targetFixedPosition, step);
    }
}