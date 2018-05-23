using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleManager : MonoBehaviour {
	
	public float x = 10.30f;
	public GameObject objectsPrefab;
	private GameSettings gameSettings;
	private float timeLeft;
	
	void Start () {
		objectsPrefab = GameObject.Find ("FloatingObjects");
		gameSettings = GameObject.FindWithTag ("GameSettings").GetComponent <GameSettings> ();
	//	Blitzkrieg.GetGameObjectPosition ();
	}

	void ObjectSpawn () {
		GameObject objectsSpawner = Instantiate (
			objectsPrefab, 
			new Vector3 (x,-3.4f,0), 
			Quaternion.Euler(0,0,0),
			gameSettings.objectSpawnParent
		);
		objectsSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (-gameSettings.objectPushForce, 0));
		Debug.Log("Hello i exist");
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = gameSettings.spawnInterval;
			ObjectSpawn ();
		}
	}
}
// > Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 1
// > Jogador tem que reagir e reage    :: Soma 1 nas vezes que ele reagiu positivamente 	> Acertou 	 = 1
// > Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 2
// > Jogador tem que reagir e não 	   :: Não soma 1 nas vezes que ele reagiu positivamente > Acertou    = 1

// Acertou / Apareceram > 0~100% de 2 estrelas. 0 - 0 est, 25, 1/2 estrela... etc.
	