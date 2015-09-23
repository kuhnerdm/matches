using UnityEngine;
using System.Collections;

public class LightMechanics : MonoBehaviour {

	public Light matchLight;
	private bool lightingUp;
	private bool lightingDown;
	private bool waiting;
	private int timer;
	private int matchCooldown;

	void Start() {
		timer = 0;
		lightingUp = false;
		lightingDown = false;
		waiting = false;
		matchCooldown = 0;
	}

	void Update() {
		if (lightingUp) {
			matchLight.intensity += 0.02f;
			timer++;
		}
		if (lightingDown) {
			matchLight.intensity -= 0.02f;
			timer++;
		}
		if (waiting) {
			timer++;
		}
		
		if (timer > 400) {
			if(lightingUp) {
				lightingUp = false;
				waiting = true;
				timer = 0;
				Debug.Log("Lighting up completed");
			}
			else if(lightingDown) {
				lightingDown = false;
				timer = 0;
				Debug.Log("Lighting down completed");
			}
			else if(waiting) {
				waiting = false;
				lightingDown = true;
				timer = 0;
				Debug.Log("Waiting completed");
			}
		}
		
		if (Input.GetKey ("space") && matchCooldown == 0) {
			matchCooldown = 1200;
			lightingUp = true;
		}
		
		if (matchCooldown > 0) {
			matchCooldown--;
		}
	}

}
