using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {
	private bool clicked = false;

	void Update () {
		if (clicked) {
			transform.position = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
	}

	public void SetClicked () {
		clicked = true;
	}

	//method called when the user already clicked 
	//on the element and is still holding down the mouse
	void OnMouseUp () {
		clicked = false;
	}
}