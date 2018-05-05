using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class joueur : MonoBehaviour {
    static public int joueurChoisis;
  
    // Use this for initialization
    void Start () {
        joueurChoisis = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void choixJ1()
    {
        joueurChoisis = 0;
    }
    public void choixJ2()
    {
        joueurChoisis = 1;
    }
    public void choixJ3()
    {
        joueurChoisis = 2;
    }
    public void choixJ4()
    {
        joueurChoisis = 3;
    }
    
}
