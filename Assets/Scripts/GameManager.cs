using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject objectsPrefab;
	float timeLeft = 5.0f;
	int x = 11

	void Start () {
		objectsPrefab = GameObject.Find ("FloatingObjects");
	//	Blitzkrieg.GetGameObjectPosition ();
	}

	void ObjectSpawn () {
		GameObject objectsSpawner = Instantiate (objectsPrefab, new Vector3 (x,-3,0), Quaternion.Euler(0,0,0));
			objectsSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (-80, 0));
			Debug.Log("Hello i exist");
		//if (x < -12) {
		//	GameObject.Destroy (objectsPrefab);
		}
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = 5.0f;
			ObjectSpawn ();
		}
	}

// > Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 1
// > Jogador tem que reagir e reage    :: Soma 1 nas vezes que ele reagiu positivamente 	> Acertou 	 = 1
// > Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 2
// > Jogador tem que reagir e não 	   :: Não soma 1 nas vezes que ele reagiu positivamente > Acertou    = 1

// Acertou / Apareceram > 0~100% de 2 estrelas. 0 - 0 est, 25, 1/2 estrela... etc.
}
	