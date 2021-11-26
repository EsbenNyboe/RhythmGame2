using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionTag : MonoBehaviour
{
    // to do: convert to Property
    public static Vector2 playerPositionReadOnly;

    private void Update()
    {
        playerPositionReadOnly = new Vector2(transform.position.x, transform.position.y);
    }
}
