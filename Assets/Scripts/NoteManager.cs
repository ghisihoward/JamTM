using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//rascunho de codigos
//instantiating musical notes
//musical notes chosen: treble, crotchet, minim, semiquaver, beam, quaver
public class NoteManager : MonoBehaviour {
	
	public float instNoteX = 10;
	public float instNoteY = 10;
	private float timeLeft;
	private GameObject notesPrefab, noteSprite;
	private GameSettings gameSettings;
	private List<Sprite> notes;

	void Start () {
		gameSettings = GameObject.FindWithTag ("GameSettings").GetComponent <GameSettings> ();
		notesPrefab = gameSettings.notesPrefab;
		timeLeft = Random.Range (gameSettings.noteSpawnInterval.x, gameSettings.noteSpawnInterval.y);
		this.setUpTexturesResources();
	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 1) {
			NotesSpawn ();
			timeLeft = Random.Range (gameSettings.noteSpawnInterval.x, gameSettings.noteSpawnInterval.y);
		}

		// Checks for clicks.
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
			Debug.Log ("clickou");

			// Makes sure "the click" hit something.
			if (hit != null) {
				Debug.Log ("hit smg");

				// Makes sure "the hit" was on an object that
				// has "Note.cs" Component.
				// hitObject.GetComponent <Note> ();
				Debug.Log (hit.transform.gameObject.tag);
				if (hit.transform.gameObject.tag == "Note") {
					hit.transform.gameObject.GetComponent <Note> ().SetClicked ();
					Debug.Log ("is note");
				}
			}
		}
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
		GameObject notesSpawner = Instantiate (
			notesPrefab, 
			new Vector3 (0, 0, 0), 
			Quaternion.Euler (0, 0, 0),
			gameSettings.notesSpawnParent
		);
		notesSpawner.GetComponent <Rigidbody2D> ().AddForce(new Vector2(gameSettings.notePushforce.x, gameSettings.notePushforce.y));
		notesSpawner.GetComponent<SpriteRenderer> ().sprite = GetRandomNotes ();
	}

	public Sprite GetRandomNotes () {
		return notes [Random.Range (0, notes.Count)];
	}
}