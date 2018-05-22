using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//rascunho de codigos
//instantiating musical notes
//musical notes chosen: treble, crotchet, minim, semiquaver, beam, quaver
public class NoteManager : MonoBehaviour {
	
	private List<Sprite> notes;
	public float timeLeft = 10.0f;
	public GameObject notesPrefab, noteSprite;
	public float instNoteX = 10;
	public float instNoteY = 10;

	void Start () {
		notesPrefab = GameObject.Find ("MusicalNotes");
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

	public void NotesSpawn () {
		noteSprite = notesPrefab;
		GameObject notesSpawner = Instantiate (notesPrefab, new Vector3 (-50, 50, 0), Quaternion.Euler (0, 0, 0));
		notesPrefab.GetComponent <Rigidbody2D> ().AddForce(new Vector2(instNoteX, instNoteY));
		noteSprite.GetComponent<SpriteRenderer> ().sprite = GetRandomNotes ();
	}

	public Sprite GetRandomNotes () {
		return notes [Random.Range (0, notes.Count)];
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 1) {
			timeLeft = 10;
		}
		if (timeLeft < 2) {
			NotesSpawn ();
		}
		Debug.Log (": " + timeLeft);
	}
}
