using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int resetCooldown;
	private int quitCooldown;
	private static int resets;
	public UnityEngine.UI.Text resetText;
	public UnityEngine.UI.Text quitConfirmText;

	void Start() {
		quitCooldown = 0;
		resetCooldown = 60;
		resetText.text = "Resets: " + resets;
		quitConfirmText.text = "";
	}

	void Update() {
		if(resetCooldown != 0) {
			resetCooldown--;
		}
		if (quitCooldown == 0) {
			quitConfirmText.text = "";
		} else {
			quitCooldown--;
		}
		if (Input.GetKey ("r") && resetCooldown == 0) {
			GameController.resets++;
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if(quitCooldown != 0) {
				Application.Quit();
			}
			else {
				quitCooldown = 300;
				quitConfirmText.text = "Press esc again to quit.";
			}
		}
	}
}
