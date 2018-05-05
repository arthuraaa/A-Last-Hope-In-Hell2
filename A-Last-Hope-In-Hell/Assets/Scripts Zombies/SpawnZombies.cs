using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class SpawnZombies : MonoBehaviour {
    public Transform zombie;
    int compteur = 0;
    public GameObject proprieteepartie;
    int nbrVagues;
     int nbrJoueurs;
    int difficulte ;
    static string Difficulte = "Facile";
    public Behaviour[] componentToEnable;
    // Use this for initialization
    void Start() {

        compteur = 0;

    }
    void Update()
    {
        
        if ( compteur == 0 && PhotonNetwork.playerList.Length==2 && PhotonNetwork.isMasterClient)
        {
           
           var z= PhotonNetwork.Instantiate(zombie.name, this.transform.position, Quaternion.identity, 0);
            compteur++;
         
                z.GetComponent<EnemyMove>().enabled = true;               
                  
        }
       
       
        
    }
   
    

}
