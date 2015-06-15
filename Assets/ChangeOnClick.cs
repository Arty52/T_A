using UnityEngine;
using System.Collections;

public class ChangeOnClick : MonoBehaviour {

	public Transform quadLocation;
	public GameObject stripeImage;

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) 
		{	// Change card
			Instantiate (stripeImage, quadLocation.position, quadLocation.rotation);
		}
	}
}
