using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class EnemySpawner : NetworkBehaviour {

	public GameObject enemyPrefab;
	public int numberOfEnemies;
	public override void OnStartServer(){
		for (int i = 0; i < numberOfEnemies; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-8.0f, 8.0f), 0.0f, Random.Range (-9.8f, 8.0f));
			Quaternion spawnRotatio = Quaternion.Euler (0.0f, Random.Range (0.0f, 180.0f), 0);
			GameObject enemy = (GameObject)Instantiate (enemyPrefab, spawnPosition, spawnRotatio);
			NetworkServer.Spawn (enemy);
		}
	}
}
