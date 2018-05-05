using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptListePlayer : MonoBehaviour {
    public List<Transform> listedejoueurs = null;
   
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        var photonViews = UnityEngine.Object.FindObjectsOfType<PhotonView>();
        foreach (var view in photonViews)
        {  
            if (PhotonNetwork.playerList.Length > listedejoueurs.Count)
            {
                var playerPrefabObject = view.gameObject;
                listedejoueurs.Add(playerPrefabObject.transform);
               
            }
        }

       /* for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
        {
            print(i);
            print(listedejoueurs[i].position);
        }*/
      
    }
}
