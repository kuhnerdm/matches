using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	
	void Start () {
		gameObject.transform.Rotate(new Vector3(0.0f, Random.Range (0.0f, 360.0f), 0.0f));
		gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		gameObject.GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0.0f, 1.0f, 0.0f);
	}
}
