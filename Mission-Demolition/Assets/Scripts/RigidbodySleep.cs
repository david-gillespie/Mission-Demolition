using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySleep : MonoBehaviour {

	private int counter = 0;
	private Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody> ();
		if (rb != null) {
			rb.Sleep ();
		}
	}

	//My castles were exploding for some reason
	void FixedUpdate (){
		if (counter < 3) {
			++counter;
			if (rb != null) {
				rb.Sleep ();
			}
		}
	}
}
