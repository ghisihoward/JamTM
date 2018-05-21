using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//rascunho de codigos
//instantiating musical notes
//musical notes chosen: treble, crotchet, minim, semiquaver, beam, quaver

public class LevelManager : MonoBehaviour {
	
	private List<Sprite> notes;
	float timeLeft = 4.0f;

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

	public Sprite GetRandomNotes () {
		return notes [Random.Range (0, notes.Count)];
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 1) {
			timeLeft = Random.Range(3f, 7f);
			GetRandomNotes ();
			Debug.Log ("working: " + timeLeft);
		}
	}
}
