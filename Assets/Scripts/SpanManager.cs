using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;

  // Start is called before the first frame update
  void Start()
  {

  }

  [SerializeField] float spawnRangeX = 20;
  [SerializeField] float spawnPosZ = 20;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.S)) {
      Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
      int animalIndex = Random.Range(0, animalPrefabs.Length);
      Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
  }
}
