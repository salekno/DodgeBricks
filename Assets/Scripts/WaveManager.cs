using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

	public int wave = 1;
	public GameObject obstacle;
	public GameObject waveCounter;
	public float waveDelay = 1.0f;


	void Start(){
		InvokeRepeating ("SpawnWave", 1.0f, waveDelay);
	}

	void SpawnWave(){
		for(int i = 0; i<((wave+1)/2); i++)
		Instantiate (obstacle).transform.SetPositionAndRotation (new Vector3 (Random.Range (-5f, 5f), 3.0f, 175.0f), Quaternion.AngleAxis (Random.Range (0f, 359f), Vector3.up));

		/*if (wave % 2 == 0) {
			Instantiate (waveCounter).transform.SetPositionAndRotation (new Vector3 (-0.587f, -0.6f, 175f), Quaternion.identity);
			Instantiate (waveCounter).transform.SetPositionAndRotation (new Vector3 (-14.586f, -0.6f, 175f), Quaternion.identity);
		}*/
		wave++;

	}


}
