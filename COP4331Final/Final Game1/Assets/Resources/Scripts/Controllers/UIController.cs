// Main menu is attached to the main camera
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	// Modify the button object's OnClick() properties in the inspector window to set button's destinations
	public void ChangeScene(string sceneName) {
		Application.LoadLevel (sceneName);
	}

	public void QuitGame() {
		Application.Quit ();
	}
}
