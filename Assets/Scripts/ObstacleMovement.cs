using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	public float speed;


	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate(){
		if (this.transform.position.z <= -200)
			Destroy (gameObject);
		
		//rb.velocity = new Vector3 (0.0f, 0.0f, -1.0f * speed);
		rb.AddForce (0f, 0f, -1f * speed);
	}
}
