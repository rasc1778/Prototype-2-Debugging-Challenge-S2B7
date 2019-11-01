using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;

  [SerializeField] float spawnRangeX = 20;
  [SerializeField] float spawnPosZ = 20;
  [SerializeField] float spawnDelay = 2;
  [SerializeField] float spawnInterval = 1.5f;

  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void SpawnRandomAnimal()
  {
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
  }
}
