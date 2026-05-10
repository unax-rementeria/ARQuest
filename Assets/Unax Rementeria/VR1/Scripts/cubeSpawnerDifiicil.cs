using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class cubeSpawnerDificil : MonoBehaviour
{
    public GameObject prefabToSpawn; 
    public GameObject prefabBomb; 
    public float spawnInterval = 2.0f; 
    private float timer;

    private float offset;
    public float distance = 8f;

    public float BombProb = 0.1f;

    score score;

    cubeMove prefabMove;

    [System.Obsolete]
    void Start()
    {
        timer = spawnInterval; 
        score = FindObjectOfType<score>();
    }

    void Update()
    {
        timer -= Time.deltaTime; // Countdown

        if (timer <= 0)
        {
            if(score._score < 20)
                if (Random.value < BombProb)
                    SpawnPrefabBomb();
                else
                    SpawnPrefab();
                    
            timer = spawnInterval; // Reset timer
        }
        
        offset = Random.Range(-1f,1f);
    }

    void SpawnPrefabBomb()
    {
        Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * distance + Camera.main.transform.right * offset;
        
        GameObject instance = Instantiate(prefabBomb, spawnPosition, Quaternion.identity);
    }

    void SpawnPrefab()
    {
        Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * distance + Camera.main.transform.right * offset;
        
        GameObject instance = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
