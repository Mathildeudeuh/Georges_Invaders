using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject[] enemy;
    public int index;
    public float minSpawnTime, maxSpawnTime;
    public float timeSpawning;
    /*
    private IEnumerator SpawnCoroutine()
    {
        while (isRunning == true)
        {
            Spawn();
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }
    private IEnumerator Timer()
    {
        
        yield return new WaitForSeconds(1);
        maxTime -= 1;
        if (maxTime < 0.1)
        {
            isRunning = false;
            maxTime = time;
        }

    }
    */
    public void StartSpawn()
    {
        StartCoroutine(SpawnCoroutine());
        //Debug.Log("statcprout");
    }
    private void Spawn()
    {
        Instantiate(enemy[index], SpawnPoint) ;
        //Debug.Log("spon");
    }

    IEnumerator SpawnCoroutine()
    {
        //Debug.Log("courout");
        var startTime = Time.time;
        while(Time.time< startTime + timeSpawning)
        {
            Spawn();
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }

    /*
    IEnumerator CoroutineTest()
    {
        var startTime = Time.time;
        while(Time.time < startTime + 20f)
        {
            Debug.Log("Coucou");
            yield return new WaitForSeconds(0.5f);
        }
    }
    */
}
