// Main menu is attached to the main camera
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void ButtonMenu (Button button) {

		if (button.name == "PlayGameButton") {
			Application.LoadLevel ("GameStagingScene");
		}
		if (button.name == "OptionsButton") {
			print ("asdf2");
		}
		if (button.name == "ExitButton") {
			print ("asdf3");
		}
	}
}
