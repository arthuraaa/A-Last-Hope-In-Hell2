﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perteBrasD : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInParent<EnemyMove>().lifezombie -= 20;
        GetComponentInParent<EnemyMove>().attaque -= 20;
        GetComponentInParent<SkinnedMeshRenderer>().enabled = false;
        this.gameObject.active = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
