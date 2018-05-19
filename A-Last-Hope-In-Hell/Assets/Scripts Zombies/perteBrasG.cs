using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perteBrasG : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "bullet")
        {
            GetComponentInParent<EnemyMove>().lifezombie -= 20;
            GetComponentInParent<EnemyMove>().attaque -= 20;
            GetComponentInParent<SkinnedMeshRenderer>().enabled = false;
            this.gameObject.active = false;
        }
    }

}
