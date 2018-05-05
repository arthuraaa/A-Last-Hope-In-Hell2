using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;
public class activationVR : MonoBehaviour {

    public Toggle boutonVR;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (boutonVR.enabled)
        {
          //  UnityEngine.VR.VRSettings.enabled = true;
           // UnityEngine.XR.XRSettings.enabled = true;
          //  UnityEditor.PlayerSettings.virtualRealitySupported = true;
           // UnityEditor.PlayerSettings.VROculus.dashSupport = true;
        }
        else
        {
            //UnityEngine.XR.XRSettings.enabled = false;
          //  UnityEditor.PlayerSettings.virtualRealitySupported = false;
        }
	}
    

}
