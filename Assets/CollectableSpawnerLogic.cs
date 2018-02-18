using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawnerLogic : MonoBehaviour {

    public GameObject collectable;
    public GameObject badCollectable;

    public float collectableSpawnTime = 1.0f;
    public float badCollectableSpawnTime = 2.0f;

    public bool canSpawnCollectable = true;
    public bool canSpawnBadCollectable = true;

    float randomXCollectable = 0.0f;
    float randomYCollectable = 0.0f;

    float randomXBadCollectable = 0.0f;
    float randomYBadCollectable = 0.0f;

    float maxX = 20.5f;
    float maxY = 9.0f;


    void Start () {
        StartCoroutine(spawnCollectables());
        StartCoroutine(spawnBadCollectables());
    }
	
	void Update () {
		
	}

    IEnumerator spawnCollectables()
    {
        while (canSpawnCollectable == true)
        {
            spawnCollectable();
            yield return new WaitForSeconds(collectableSpawnTime);
        }
    }

    IEnumerator spawnBadCollectables()
    {
        while (canSpawnBadCollectable == true)
        {
            spawnBadCollectable();
            yield return new WaitForSeconds(badCollectableSpawnTime);
        }
    }

    void spawnCollectable()
    {
        randomXCollectable = Random.Range(-maxX, maxX);
        randomYCollectable = Random.Range(-maxY, maxY);

        Instantiate(collectable, new Vector3(randomXCollectable, randomYCollectable, 0), Quaternion.identity);
    }

    void spawnBadCollectable()
    {
        randomXBadCollectable = Random.Range(-maxX, maxX);
        randomYBadCollectable = Random.Range(-maxY, maxY);

        Instantiate(badCollectable, new Vector3(randomXBadCollectable, randomYBadCollectable, 0), Quaternion.identity);
    }
}
