using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public float healthMax = 200;
	private float health;

	public Text hud;

	// Use this for initialization
	void Start () {
		health = healthMax;
	}
	
	// Update is called once per frame
	void Update () {

		//hud.text = "Hp : " + health + "/" + healthMax;

	}

	public void Damage(float value){
		health -= value;
	}
}
