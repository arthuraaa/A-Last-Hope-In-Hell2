using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacements1 : MonoBehaviour {

	public int Speed = 3;
	public int RunSpeed = 10;
	private Vector3 DirectionDeplacement = Vector3.zero;
	private CharacterController Player;

	public float gravite = 20;

	public int Sensi;
	public int Jump=3;
	private Animator Anim;
	[SerializeField]
	private Camera cam;

	private Vector3 cameraRotation;

	float vy = 0;


	// Use this for initialization
	void Start () {
		Player = GetComponent<CharacterController> ();
		Anim = GetComponent<Animator> ();

	}


		

	
	// Update is called once per frame
	void Update () 
	{
		DirectionDeplacement.z = Input.GetAxisRaw ("Vertical");
		DirectionDeplacement.x = Input.GetAxisRaw ("Horizontal");
		DirectionDeplacement = transform.TransformDirection (DirectionDeplacement);

		//Deplacements

		if (Input.GetKey (KeyCode.LeftShift)) {
			DirectionDeplacement.x *= Time.deltaTime * RunSpeed;
			DirectionDeplacement.z *= Time.deltaTime * RunSpeed;
		} else {
			DirectionDeplacement.x *= Time.deltaTime * Speed;
			DirectionDeplacement.z *= Time.deltaTime * Speed;
		}
		DirectionDeplacement.y *= Time.deltaTime * Speed;

		Player.Move (DirectionDeplacement);

		/*if (Input.GetKey (KeyCode.LeftShift)) {
			Player.Move (DirectionDeplacement * Time.deltaTime * RunSpeed);
		} else {
			Player.Move (DirectionDeplacement * Time.deltaTime * Speed);
		}*/

		transform.Rotate (0, Input.GetAxisRaw ("Mouse X") *Sensi, 0);

		//transform.Rotate ((-Input.GetAxisRaw ("Mouse Y")) *Sensi, 0, 0);





		//float _xRot = Input.GetAxisRaw ("Mouse Y");
		//Vector3 _cameraRotation = new Vector3 (_xRot, 0, 0) * Sensi;
		//transform.RotateCamera (_cameraRotation);

		//Gravité
		if (!Player.isGrounded) {
			DirectionDeplacement.y /= Time.deltaTime * Speed;
			DirectionDeplacement.y -= gravite * Time.deltaTime;
		} else {
			DirectionDeplacement.y = 0;
		}

		//saut

		if (Input.GetKeyDown (KeyCode.Space) && Player.isGrounded) 
		{
			DirectionDeplacement.y = Jump;
			Anim.SetTrigger ("Jumping");
		}





		//Animations

		if (Input.GetKey (KeyCode.Z) & !Input.GetKey (KeyCode.LeftShift)) 
		{
			Anim.SetBool ("Walk", true);
			Anim.SetBool ("Run", false);
		}
		if (Input.GetKey (KeyCode.Z) & Input.GetKey (KeyCode.LeftShift)) 
		{
			Anim.SetBool ("Walk", true);
			Anim.SetBool ("Run", true);
		}
		if (!Input.GetKey (KeyCode.Z) & Input.GetKey (KeyCode.LeftShift)) 
		{
			Anim.SetBool ("Walk", false);
			Anim.SetBool ("Run", false);
		}
		if (!Input.GetKey (KeyCode.Z)) 
		{
			Anim.SetBool ("Walk", false);

		}

	}
}
