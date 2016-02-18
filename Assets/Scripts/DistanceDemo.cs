using UnityEngine;
using System.Collections;

public class DistanceDemo : MonoBehaviour {

	public Transform cube, sphere;


	// Update is called once per frame
	void Update () {
		//more code, but gives you direction/orientation
		Vector3 vectorBetweenTwoPoints = (cube.position - sphere.position);
		if (vectorBetweenTwoPoints.magnitude > 5f && vectorBetweenTwoPoints.magnitude < 10f){
			Debug.Log("u win");
			cube.gameObject.SetActive(false); //disables cube
		}else{
			Debug.Log("u lose");
		}

	// ONLY tells you distance, no direction
	float distance = Vector3.Distance(cube.position, sphere.position);
	Debug.Log ("u r" + distance.ToString() + "units apart");
	}
}
