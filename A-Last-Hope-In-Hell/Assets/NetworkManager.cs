using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NetworkManager : MonoBehaviour {

    public float version_a_choisir;
    public Text connection_settings;
    public InputField ServeurNameCreate;
    public InputField ServeurNameJoin;
    public Text Version;
    public int map = 1;
    public Transform proprieteePartie;
    public Transform Joueur;
   


    private void Start()
    {
        Version.text ="Version: "+ version_a_choisir.ToString();
        PhotonNetwork.ConnectUsingSettings(version_a_choisir.ToString());
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(Joueur);
    }

    private void Update()
    {
              connection_settings.text = PhotonNetwork.connectionState.ToString();
       
    }
    public void CreateRoom()
    {
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 8;
        options.IsOpen = true;
        options.IsVisible = true;
        

        //  PhotonNetwork.JoinLobby(); //c'est moi

       // connection_settings.text = "Le serveur: " + ServeurName.text + "a été crée";

        PhotonNetwork.CreateRoom(ServeurNameCreate.text, options, TypedLobby.Default);
        print("serveur crée!");

       
        Application.LoadLevel(map);
        PhotonNetwork.Instantiate(proprieteePartie.name, this.transform.position, Quaternion.identity, 0);
        DontDestroyOnLoad(proprieteePartie);

    }

    public void JoinServer()
    {
        PhotonNetwork.JoinRoom(ServeurNameJoin.text);
        Application.LoadLevel(1);
    }
    public void ChoixJoueurSmith()
    {
        map = 1;
    }
    public void Choixmap1()
    {
        map = 1;
    }
    public void Choixmap2()
    {
        map = 2;
    }
    void OnJoinedRoom()
    {
        print("serveur rejoins");
    }
    
}
