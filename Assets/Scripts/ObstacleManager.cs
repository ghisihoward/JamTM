using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleManager : MonoBehaviour {
	
	public float x = 10.30f;
	public GameObject objectsPrefab;
	private GameSettings gameSettings;
	private float timeLeft;
	private GameObject sharkPrefab, islandPrefab;
	
	void Start () {
		sharkPrefab = GameObject.Find ("Shark");
		islandPrefab = GameObject.Find ("Island");
		gameSettings = GameObject.FindWithTag ("GameSettings").GetComponent <GameSettings> ();
	}

	void Update () {
		timeLeft += Time.deltaTime;
		if (timeLeft == 10f) {
			IslandSpawn ();
		} else if (timeLeft == 5f) {
			SharkSpawn ();
		}
		else if (timeLeft == 20f) {
			timeLeft = gameSettings.spawnInterval;
		}
	}

	void IslandSpawn () {
		GameObject islandSpawner = Instantiate (
			islandPrefab, 
			new Vector3 (x,-3.1f,0), 
			Quaternion.Euler(0,0,0),
			gameSettings.objectSpawnParent
		);
		islandSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (-gameSettings.objectPushForce, 0));
		Debug.Log("Hello island");
	}

	void SharkSpawn () {
		GameObject sharkSpawner = Instantiate (
			sharkPrefab, 
			new Vector3 (x,-3.1f,0), 
			Quaternion.Euler(0,0,0),
			gameSettings.objectSpawnParent
		);
		sharkSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (-gameSettings.objectPushForce, 0));
		Debug.Log("Hello shark");
	}
}