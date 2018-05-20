using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour {

	//this sees when other colliders make contact with this collider
	void OnCollisionEnter2D(Collision2D coll) {
	Destroy (coll.gameObject);
	}
}
