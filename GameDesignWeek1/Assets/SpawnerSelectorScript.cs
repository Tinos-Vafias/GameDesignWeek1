using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSelectorScript : MonoBehaviour
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
            int random_index = Random.Range(0, spawners.Length);
            SpawnerBase spawner = spawners[random_index].GetComponent<SpawnerBase>();
            if (spawner is not null)
                spawner.Spawn();
            else Debug.LogWarning($"index {random_index} is missing a script");

            timer = 0;
        }
    }
}
