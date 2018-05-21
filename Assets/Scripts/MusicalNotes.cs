using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rascunho de codigos
//instantiating musical notes
//musical notes chosen: treble, crotchet, minim, semiquaver, beam, quaver

public class MusicalNotes : MonoBehaviour {
	/*
	public GameObject musicalNotes;
	private List<Sprite> notes;
	float timeLeft = 4.0f;);
	//note position
	float y = 4f;
	float x = 2f;

	void Start () {
		this.setUpTexturesResources();
	}

	private void setUpTexturesResources () {
		notes = loadTextures("Notes/");
	}

	private List <Sprite> loadTextures (string folder) {
		try {
			return Resources.LoadAll(folder, typeof(Sprite)).Cast<Sprite>().ToList();
		} catch (UnityException e) {
			Debug.Log ("Loading image database failed:");
			Debug.Log (e);
			return null;
		}
	}

	public Sprite NotesSpawn () {
		GameObject noteSpawner = Instantiate (notes, new Vector3 (x,y,0), Quaternion.Euler(0,60,0));
		noteSpawner.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (10, 10));
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 1) {
			timeLeft = Random.Range(3f, 7f);
			Sprite NotesSpawn ();
		}
	}
	*/
}
