using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AXEY : MonoBehaviour {
	public int Sensi = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        
        
        /*if ((float) (this.transform.rotation.x) > 0.5f)
        {
            print("trop bas");
            transform.Rotate(this.transform.rotation.x -0.5f- 0.1f, 0, 0);                
        }
        else
         if ((float)(this.transform.rotation.x) < -0.5f)
        {
           
            transform.Rotate(this.transform.rotation.x + 0.5f + 0.1f, 0, 0);
        }
        else*/
        {
           // print("cam" + this.transform.rotation.x);
            transform.Rotate((-Input.GetAxisRaw("Mouse Y")) * Sensi, 0, 0);
        }
            

       
	}
}
