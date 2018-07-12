using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleManager : MonoBehaviour {
	
	public float x;
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
        Debug.Log ("time: " + timeLeft);
        timeLeft += Time.deltaTime;

        InvokeRepeating("IslandSpawn", 2.0f, 0.5f);

        //if (timeLeft >= 5f) {
        //if ((int)(timeLeft % gameSettings.spawnIntervalIsland) >= 2) {
        //	Debug.Log ("time left island" + timeLeft);
        //	IslandSpawn ();
        //    timeLeft = Random.Range(-0.0f, 11.0f);
        //}

        //else if (timeLeft >= 6f) {
        //    SharkSpawn ();
        //    if (timeLeft >= 12.0f) {
        //        timeLeft = Random.Range(-0.0f, 10.0f);
        //    }
        // }
    }

    //else if ((int) (timeLeft % gameSettings.spawnIntervalIsland) == 0) {
    //SharkSpawn ();
    //}

    // 6/2 = 3 (0)
    // 5/2 = 2 (1)
    // 10/4 = 2 (2)
    // 100/33 = 3 (1)
    // 70/10 = 7 (0)

    // intIlha = 10, intTub = 7;
    // 84/10 = 8  (4)
    // 84.8X5424324131/7  = 12 ((int)0)
    // sempre que (int)(TempoDeJogo % IntervaloDeSpawn) == 0 do stuff;


    void IslandSpawn () {
		GameObject islandSpawner = Instantiate (
			islandPrefab, 
			new Vector3 (x,-3.1f,0), 
			Quaternion.Euler(0,0,0),
			gameSettings.objectSpawnParent
		);
		islandSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (-gameSettings.objectPushForce, 0));
		Debug.Log("Hello island");
		timeLeft = 0;
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

    void ShootingStar() {

    }

    void CloudSpawn() {

    }

    void Seagull() {

    }

    void Whale() {
        //void OnCollisionEnter2D(Collision2D coll) {

        //}
    }
}