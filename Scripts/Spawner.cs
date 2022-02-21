using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn;

    private bool spawnObj = true;
    private float spawnTimer = 5f;


    private void Update()
    {
        if (spawnObj == true)
        {
            Instantiate(objToSpawn, transform.position, Quaternion.identity);
            spawnObj = false;
            Invoke(nameof(StartSpawn), spawnTimer);
        }
    }


    private void StartSpawn()
    {
        spawnObj = true;
    }
}
