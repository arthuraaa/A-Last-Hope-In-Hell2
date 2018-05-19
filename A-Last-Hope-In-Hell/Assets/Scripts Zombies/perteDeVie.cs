using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class perteDeVie : MonoBehaviour {
      
	// Use this for initialization
	void Start () {
	

    }
	
	// Update is called once per frame
	void Update () {
      		
	}
    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "bullet")
        {
            print("touché");
            GetComponentInParent<EnemyMove>().lifezombie -= 10;
        }
    }
}
