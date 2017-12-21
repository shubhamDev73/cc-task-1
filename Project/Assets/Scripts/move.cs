using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

	public float initialVelocity, acceleration;

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * initialVelocity, ForceMode.VelocityChange);
	}

	void FixedUpdate () {
		rb.AddForce(transform.forward * acceleration, ForceMode.Acceleration);
	}

	void OnTriggerEnter (Collider col) {
		GameObject.Find("EndText").GetComponent<Text>().text = "Time taken to collide: " + Time.time.ToString() + "s";
		Time.timeScale = 0f;
	}
}
