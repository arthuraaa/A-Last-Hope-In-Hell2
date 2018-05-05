using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheminDeTraverse : MonoBehaviour {
    public Slider sliderNbrJoueurs;
    public Text textNbrJoueur;
    public Slider sliderNbrVagues;
    public Text textNbrVagues;
     public  int nbrVagues = -1;
    public  int nbrJoueurs = -1;
     // Use this for initialization
    void Start()
    {

        //Instantiate(gameObject, this.transform.position, Quaternion.identity);
        PhotonNetwork.Instantiate(gameObject.name, this.transform.position, Quaternion.identity, 0);
        DontDestroyOnLoad(gameObject);


    }
	
	// Update is called once per frame
	void Update () {
        /*
        textNbrJoueur.text = sliderNbrJoueurs.value.ToString();
        textNbrVagues.text = sliderNbrVagues.value.ToString();
        nbrJoueurs = int.Parse( sliderNbrJoueurs.value.ToString());
        nbrVagues = int.Parse(sliderNbrVagues.value.ToString());*/
   
        textNbrJoueur.text = sliderNbrJoueurs.value.ToString();
        textNbrVagues.text = sliderNbrVagues.value.ToString();
        nbrJoueurs = int.Parse(sliderNbrJoueurs.value.ToString());
        nbrVagues = int.Parse(sliderNbrVagues.value.ToString());
       

    }
}
