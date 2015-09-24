using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int quitCooldown;
	private static int resets;
	public UnityEngine.UI.Text resetText;
	public UnityEngine.UI.Text quitConfirmText;
	
	void Start() {
		quitCooldown = 0;
		resetText.text = "Resets: " + resets;
		quitConfirmText.text = "";
	}
	
	void Update() {
		if (quitCooldown == 0) {
			quitConfirmText.text = "";
		} else {
			quitCooldown--;
		}
		if (Input.GetKey ("r") && quitCooldown != 0) {
			GameController.resets++;
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if(quitCooldown != 0) {
				Application.Quit();
			}
			else {
				quitCooldown = 300;
				quitConfirmText.text = "Press esc again to quit. Press R to reset.";
			}
		}
	}
}