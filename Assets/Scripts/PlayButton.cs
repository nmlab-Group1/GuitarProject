using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton () {
		Application.LoadLevel ("GameScene");
		//AutoFade.LoadLevel("GameScene", 3, 1, Color.white);
	}
}
