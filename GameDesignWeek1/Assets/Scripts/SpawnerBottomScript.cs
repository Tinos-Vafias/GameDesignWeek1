using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBottomScript : SpawnerBase
{
    public GameObject circle_enemy;
    public float x_offset;

    public override void Spawn()
    {
        if (circle_enemy is not null)
        {
            float leftmost_point = transform.position.x - x_offset;
            float rightmost_point = transform.position.x + x_offset;

            Instantiate(circle_enemy,
                new Vector3(
                    Random.Range(leftmost_point, rightmost_point),
                    transform.position.y),
                transform.rotation);
        }
    }
}
