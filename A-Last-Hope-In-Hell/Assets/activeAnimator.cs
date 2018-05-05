using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Animator>().enabled = true; 
    }
}
