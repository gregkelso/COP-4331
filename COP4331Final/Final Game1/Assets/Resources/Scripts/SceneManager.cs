using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	static SceneManager instance;

	void start() {
		if (instance != null) {
			GameObject.Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			instance = this;
		}
	}

	void update() {
		if (Input.GetKeyUp (KeyCode.A)) {
			Application.LoadLevel ("MainMenu");
		}
		if (Input.GetKeyUp (KeyCode.B)) {
			Application.LoadLevel ("GameStagingScene");
		}
	}
}
