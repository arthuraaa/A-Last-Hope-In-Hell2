using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTete : MonoBehaviour {
    public GameObject bullet;
    // Use this for initialization
    void Start () {
        GetComponentInParent<EnemyMove>().lifezombie -= 1000;
        GetComponentInParent<SkinnedMeshRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
