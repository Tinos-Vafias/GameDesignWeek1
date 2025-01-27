using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSelector : MonoBehaviour
{
    public GameObject circle_enemy;

    public float spawn_rate;
    private float timer = 0;
    private GameObject[] spawners;

    // Start is called before the first frame update
    void Start()
    {
        if (spawners is null || spawners.Length == 0)
        {
            spawners = GameObject.FindGameObjectsWithTag("Spawner");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spawners is null || spawners.Length == 0)
        {
            Debug.Log("no spawners bruh");
            return;
        }
        if (timer < spawn_rate)
        {
            timer += Time.deltaTime;
        } else
        {
            int randomIndex = Random.RandomRange(0, spawners.Length);

            timer = 0;
        }
    }
}
