using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

	public float speed;


	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (this.transform.position.y <= -0.5f) {
			FindObjectOfType<PlayerCollision> ().GameOver ();
		}

		#if UNITY_STANDALONE || UNITY_WEBPLAYER || UNITY_EDITOR

		float moveHorizontal = Input.GetAxisRaw ("Horizontal");

		#else

		float moveHorizontal = Input.acceleration.x * 1.5f;

		#endif

		Vector3 movement = new Vector3 (moveHorizontal, 0, 0);
		rb.AddForce (movement * speed * Time.deltaTime, ForceMode.VelocityChange);



	}




}
