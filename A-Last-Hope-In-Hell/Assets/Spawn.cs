using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Spawn : MonoBehaviour {
    public Transform player;
    public int numeroJoueur;
    public Transform[] ListeJoueur;
     void Start()
    {
   
    }
    void OnJoinedRoom ()
    {
        
        numeroJoueur = joueur.joueurChoisis;
        player = ListeJoueur[numeroJoueur];
        print(player);
        PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity, 0);
       
    }
}
