using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {
	void OnMouseEnter(){
		renderer.material.color = Color.red;
	}

	void OnMouseExit(){
		renderer.material.color = Color.white;
	}

	void OnMouseUpAsButton(){
		Application.Quit ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			GameObject.Find("txtQuit").renderer.enabled = true;		
		}
		else if (Input.GetKeyDown (KeyCode.Space)){
			GameObject.Find("txtQuit").renderer.enabled = false;	
		}
	}
}
