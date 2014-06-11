using UnityEngine;
using System.Collections;

public class GameString_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter () {
		if (!audio.isPlaying) {
			audio.Play ();
		}
	}
}
