using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryBullet : MonoBehaviour {

	// Use this for initialization


	void OnCollisionEnter(Collision Col)
	{
		Destroy (gameObject);
	}
}
