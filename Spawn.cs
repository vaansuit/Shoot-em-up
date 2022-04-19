using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] enemies;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", rate, rate);
    }

    void SpawnEnemy() {
        Instantiate(enemies[(int)Random.Range(0, enemies.Length)], new Vector3 (Random.Range(-8.5f, 8.5f), 7, 0), Quaternion.identity);

    }
}
