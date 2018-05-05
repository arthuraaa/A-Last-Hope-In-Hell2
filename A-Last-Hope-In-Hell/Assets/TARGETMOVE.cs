using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TARGETMOVE : MonoBehaviour {
	int Sensi =5;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        	transform.Rotate (0, (-Input.GetAxisRaw ("Mouse Y")) * Sensi, 0);
        /*if ((float)(this.transform.rotation.x) > 0.5f)
        {
            transform.Rotate(0, 0.1f, 0);
        }
        else
         if ((float)(this.transform.rotation.x) < -0.5f)
        {
            transform.Rotate(0, -0.1f, 0);
        }
        else
        {
            transform.Rotate(0, (-Input.GetAxisRaw("Mouse Y")) * Sensi, 0);
        }*/
    }
}
