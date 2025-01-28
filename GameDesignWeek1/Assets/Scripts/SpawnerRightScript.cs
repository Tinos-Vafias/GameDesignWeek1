using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRightScript : SpawnerBase
{
    public GameObject circle_enemy;
    public float y_offset;

    public override void Spawn()
    {
        if (circle_enemy is not null)
        {
            float highest_point = transform.position.y - y_offset;
            float lowest_point = transform.position.y + y_offset;

            Instantiate(circle_enemy,
                new Vector3(
                    transform.position.x,
                    Random.Range(lowest_point, highest_point)
                ),
                transform.rotation);
        }
    }
}
