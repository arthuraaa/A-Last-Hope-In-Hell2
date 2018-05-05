using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tir : MonoBehaviour {
	public GameObject Projectile;
	public GameObject player;

	public GameObject muzzleFlash;

	public float maxVerticalRecoil = 1;
	public float maxHorizontalRecoil = 2;

	public int Force = 50;
	public AudioClip SoundTir;
	public AudioClip SoundEmpty;
	public AudioClip SoundReload;
	public Light light;

	public float coolDown = 0.2f;

	private float lastShoot;
	private bool flash = false;

	public int clipSize;
	private int clip;
	private bool reloading = false;
	public float reloadTime = 1;
	public float lastReload;

	public Text hudAmmo;

	// Use this for initialization
	void Start () {

		lastShoot = Time.time;
		clip = clipSize;

		lastReload = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time - coolDown >= lastShoot && clip > 0 && !reloading) {
			GetComponent<AudioSource> ().PlayOneShot (SoundTir);

			RaycastHit raycastHit;
			Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out raycastHit, Mathf.Infinity);
			if (raycastHit.collider != null)
				Debug.DrawLine (gameObject.transform.position, raycastHit.point);


            if (raycastHit.collider.tag == "BrasL")
            {
                print("brasL");
                raycastHit.collider.gameObject.GetComponent<perteBrasG>().enabled = true;
            }
            if (raycastHit.collider.tag == "BrasR")
            {
                print("brasR");
                raycastHit.collider.gameObject.GetComponent<perteBrasD>().enabled = true;
            }

            if (raycastHit.collider.tag == "HeadZombie")
            {
                raycastHit.collider.gameObject.GetComponent<ExplosionTete>().enabled = true;
            }

            if (raycastHit.collider.tag == "zombie")
            {
                raycastHit.collider.gameObject.GetComponent<EnemyMove>().lifezombie -= 10;
            }

            lastShoot = Time.time;
			clip--;

			Recoil ();

			flash = true;
			light.intensity = 5;

			muzzleFlash.GetComponent<ParticleSystem> ().Play ();

		} else if (Input.GetButtonDown ("Fire1") && Time.time - coolDown >= lastShoot && clip == 0) {
			GetComponent<AudioSource> ().PlayOneShot (SoundEmpty);
		}

		if (flash && Time.time - 0.1f >= lastShoot) {
			light.intensity = 0;
		}

		if(Input.GetKeyDown("r") && !reloading && clip < clipSize){
			Reload();
		}
		if (reloading && Time.time - reloadTime > lastReload) {
			reloading = false;
		}

		hudAmmo.text = clip + " / " + clipSize + " ";


	}

	void Reload(){
		clip = clipSize;
		reloading = true;

		lastReload = Time.time;

		GetComponent<AudioSource> ().PlayOneShot (SoundReload);
	}

	void Recoil(){

		float verticalRecoil;
		verticalRecoil = -(maxVerticalRecoil + Random.Range (-2, 2));

		float horizontalRecoil;
		horizontalRecoil = Random.Range (-maxHorizontalRecoil, maxHorizontalRecoil);

		gameObject.transform.Rotate(new Vector3 (0, verticalRecoil, 0));
		player.transform.Rotate(new Vector3 (0, horizontalRecoil, 0));

		Camera mainCam = Camera.main;
		mainCam.transform.Rotate (new Vector3 (verticalRecoil, 0, 0));
	}
}
