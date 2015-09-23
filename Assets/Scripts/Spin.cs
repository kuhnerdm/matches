using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	
	void Start () {
		gameObject.GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0.0f, 1.0f, 0.0f);
	}
}
