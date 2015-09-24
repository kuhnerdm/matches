using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
	
	public float speed;
	public GameObject camera;
	
	void Update() {
		float moveX = Input.GetAxis ("Horizontal") * speed;
		float moveZ = Input.GetAxis ("Vertical") * speed;
		gameObject.transform.position = gameObject.transform.position + camera.transform.right * moveX * speed + camera.transform.forward * moveZ * speed;
		
		float newPosX = gameObject.transform.position.x;
		float newPosZ = gameObject.transform.position.z;
		gameObject.transform.position = new Vector3 (newPosX, 3.0f, newPosZ);
	}

	void FixedUpdate() {
		gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Exit") {
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
	
}
