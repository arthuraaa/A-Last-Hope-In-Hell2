using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTete : MonoBehaviour {
    public GameObject bullet;
    public GameObject headZombie;
    public GameObject zombie;
    // Use this for initialization
    void Start () {
       
    }

    private void Update()
    {
       
        
       // print("GameObject" + x);
        //print("Nothing" + this.transform.position);
    }
    // Update is called once per frame

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "bullet")
        {
            print("tete!");
            GetComponentInParent<EnemyMove>().lifezombie -= 1000;
            GetComponentInParent<SkinnedMeshRenderer>().enabled = false;
        }
    }
    public void touche()
    {
        var x = headZombie.gameObject.transform.localPosition + zombie.gameObject.transform.localPosition;
        PhotonNetwork.Instantiate(bullet.name, x, Quaternion.identity, 0);
    }

}
