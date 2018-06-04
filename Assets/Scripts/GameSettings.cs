using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

	[Range (1f, 20f)]
	public float spawnInterval = 5f;

	[Range (10, 160)]
	public float objectPushForce = 80f;

	public Vector2 notePushforce = new Vector2 (10, 10);
	public Vector2 noteSpawnInterval = new Vector2 (5f, 20f);
	public GameObject notesPrefab, shark, island;
	public Transform objectSpawnParent, notesSpawnParent;
}