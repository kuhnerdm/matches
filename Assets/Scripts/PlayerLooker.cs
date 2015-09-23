using UnityEngine;
using System.Collections;

public class PlayerLooker : MonoBehaviour {

	public float rotSpeed;

	void Update () {
		float rotX = Input.GetAxis ("Mouse X") * rotSpeed;
		float rotY = -Input.GetAxis ("Mouse Y") * rotSpeed;
		gameObject.transform.rotation = gameObject.transform.rotation * Quaternion.Euler(new Vector3(rotY, rotX, 0.0f));
		float newRotX = gameObject.transform.rotation.eulerAngles.x;
		float newRotY = gameObject.transform.rotation.eulerAngles.y;
		gameObject.transform.rotation = Quaternion.Euler(new Vector3(newRotX, newRotY, 0));
	}
}
