using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour {
    [SerializeField]
    
    //Transform _emplacementZombie;
    public int lifezombie = 100;//
    public float vitesseZombie = 1;
    public int focus = 2000; // distance au dela de laquel le zombie "décroche" le joueur
    public int attaque = 20;
    private float temps =0;
    public Transform JoueurAAttaquer ;

    public Transform ObjectifDuZombie ;

    static public NavMeshAgent _navMeshAgent; //rajout static

    public Animator anim;

    public AudioClip[] soundZombieMarche;
    public AudioClip[] soundZombieAttack;
    public AudioSource audioSource;
    public List<Transform> listedejoueurs = null;




    // Use this for initialization
    void Start () {
       // JoueurAAttaquer  = GameObject.FindWithTag("objectif").transform;
        //ObjectifDuZombie = GameObject.FindWithTag("objectif").transform;

        audioSource = GetComponent<AudioSource>();
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = vitesseZombie;//
        anim.speed = vitesseZombie;//
      

        if (_navMeshAgent == null)
        {
            Debug.LogError("probleme vaec le mesh agent");
        }
        else
        {           
            SetDestination();
        }
	}

    private void SetDestination()
    {
       
        var photonViews = UnityEngine.Object.FindObjectsOfType<PhotonView>();// On stock les joueurs dans la listedejoueur
        foreach (var view in photonViews)
        {
            if (PhotonNetwork.playerList.Length > listedejoueurs.Count)
            {
                var playerPrefabObject = view.gameObject;
                if (playerPrefabObject.tag == "joueur")
                {
                    listedejoueurs.Add(playerPrefabObject.transform);
                }
            }
        }

       // print(listedejoueurs.Count);

        JoueurAAttaquer = listedejoueurs[0];
        for (int i = 0; i < listedejoueurs.Count; i++)
        {
        if ((listedejoueurs[i].position - this.transform.position).magnitude< (JoueurAAttaquer.position - this.transform.position).magnitude)
            {
                JoueurAAttaquer = listedejoueurs[i]; //si un autre joueur est plus proche du zombie
            }
        }
        
        Vector3 distanceZombieJoueur = JoueurAAttaquer.position - this.transform.position;
       if(( distanceZombieJoueur.magnitude < focus)) // si le joueur est assez pres du zombie
        {
            print("joueur");
            Vector3 targetVector = JoueurAAttaquer.transform.position;
            _navMeshAgent.SetDestination(targetVector);
            
        }
       else
        {
            print("drapeau");
            Vector3 targetVector2 = ObjectifDuZombie.transform.position;
            _navMeshAgent.SetDestination(targetVector2);
        }
    }

    // Update is called once per frame
    void Update () {

       
        //Debug.LogAssertion(_destination.position+""+this.transform.position);
        if (lifezombie <= 0)//
        {
            anim.StopRecording();
           anim.StopPlayback();            
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsDead", true);
            _navMeshAgent.speed = 0;
            //destroyBody();
            
        }
        else
        if ((Vector3.Distance(JoueurAAttaquer.position, this.transform.position) < 2.5f) )
        {
            if (!audioSource.isPlaying)
            {
                audioSource.pitch = UnityEngine.Random.Range(0.80f, 1.30f);
                audioSource.PlayOneShot(soundZombieMarche[UnityEngine.Random.Range(0, soundZombieMarche.Length - 1)]);
            }
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsAttacking", true);
        }

        else
        {
            if (!audioSource.isPlaying)
            {
                audioSource.pitch = UnityEngine.Random.Range(0.80f, 1.30f);
                audioSource.PlayOneShot(soundZombieMarche[UnityEngine.Random.Range(0,soundZombieMarche.Length-1)]);
            }            
            anim.SetBool("IsAttacking", false);
            anim.SetBool("IsWalking", true);
        } 
        
        SetDestination();
    }

    
}
