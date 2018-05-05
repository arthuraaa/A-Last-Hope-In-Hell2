using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruitagesZombie : MonoBehaviour {

    public AudioClip[] ZombieMarcheSound;
    private AudioSource audiosource;

	void Start () {
        audiosource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ZombieMarche()
    {
        audiosource.PlayOneShot(ZombieMarcheSound[0]);
       
    }
}
