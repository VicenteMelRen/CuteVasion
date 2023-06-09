using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
  public Transform enemyPrefab;

  public float timeBetweenWaves = 5f;

  public Transform spawnPoint;

  private float countdown = 2f;
  
  private int  waveIndex = 2;

  void Update()
  {
	  if (countdown <=0f)
	  {
		  StartCoroutine(SpawnWave());
		  countdown = timeBetweenWaves;
	  }
	  countdown -= Time.deltaTime;
  }

  IEnumerator SpawnWave()
  {
	  waveIndex ++;
	  for (int i = 0; i < waveIndex; i++)
	  {
		  SpawnEnemy();
		  yield return new WaitForSeconds(0.5f);
	  }
	 
  }
  void SpawnEnemy ()
  {
	  Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
  }
}
