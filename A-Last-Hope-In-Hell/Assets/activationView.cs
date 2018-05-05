using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activationView : MonoBehaviour {
    [SerializeField]
    public Behaviour[] componentToEnable;
    public Behaviour[] componentToDisable;
	// Use this for initialization
	void Start () {
        print("start");
		if (GetComponent<PhotonView>().isMine)
        {


            for (int i = 0; i < componentToEnable.Length; i++)
            {
                componentToEnable[i].enabled = true;
            }

            print("1");

            //GetComponent<IKControl>().enabled = true;
            GetComponent<Deplacements1>().enabled = true;                      
            GetComponent<plusdesouris>().enabled = true;
            GetComponent<CharacterController>().enabled = true;
            
            

        }
        else
        {
            print("2");
            // GetComponent<IKControl>().enabled = false;
            GetComponent<Deplacements1>().enabled = false;                   
            GetComponent<plusdesouris>().enabled = false;
            GetComponent<CharacterController>().enabled = false;
            for(int i=0; i< componentToDisable.Length; i++)
            {
                componentToDisable[i].enabled = false;
            }
          
        }
	}
	
	
}
