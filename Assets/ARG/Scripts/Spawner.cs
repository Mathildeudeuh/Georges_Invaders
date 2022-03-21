using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public int index;
    bool isRunning;
    public float minSpawnTime, maxSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnCoroutine()
    {
        isRunning = true;
        while (isRunning)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            Spawn();
        }
        
    }

  
    
    private void Spawn()
    {
        Instantiate(enemy[index], transform.position, Quaternion.identity) ;
        //Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
