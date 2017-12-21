using UnityEngine;

public class camChase : MonoBehaviour {

	private Vector3 offset;

	void Start () {
		offset = transform.position - GetCentre();
	}

	void LateUpdate () {
		transform.position = offset + GetCentre();
	}

	Vector3 GetCentre () {
		Vector3 centre = Vector3.zero;
		int count = 0;
		foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Player")){
			count++;
			centre += obj.transform.position;
		}
		return centre/count;
	}
}
