using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoixMap : MonoBehaviour {

    public Button map1;
    public Button map2;
    int choix;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (map1.isActiveAndEnabled)
        {
            choix = 1;
        }
        else
        {
            choix = 2;
        }
	}
}
