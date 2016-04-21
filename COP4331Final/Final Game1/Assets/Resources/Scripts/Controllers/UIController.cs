// Main menu is attached to the main camera
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public GameObject PauseUI;

	private bool paused = false;
	private GameObject MainCamera;

	void Start() {
		PauseUI.SetActive (false);
		MainCamera = GameObject.FindWithTag ("MainCamera");
	}

	void Update() {
		if (Input.GetButtonDown("Pause")) {
			paused = !paused;
		}
		if (paused) {
			PauseUI.SetActive (true);
			Time.timeScale = 0;
			MainCamera.GetComponent<AudioSource> ().Pause ();
		}
		if (!paused) {
			PauseUI.SetActive (false);
			Time.timeScale = 1;
			//MainCamera.GetComponent<AudioSource> ().Play ();
		}
	}

	public void ResumeGame() {
		paused = false;
		MainCamera.GetComponent<AudioSource> ().Play ();
	}

	// Modify the button object's OnClick() properties in the inspector window to set button's destinations
	public void ChangeScene(string sceneName) {
		SceneManager.LoadScene (sceneName);
	}

	public void QuitGame() {
		Application.Quit ();
	}


}
