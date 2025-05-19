using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigater : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    GameObject C06;
    Animator animator;
    bool Ded;
    // Start is called before the first frame update
    void Start()
    {
        Ded = false;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        C06 = transform.GetChild(0).gameObject;
        target = player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = C06.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }

    public void SpeedChange(float speed)
    {
        agent.speed = speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(GetComponent<Rigidbody>());
        if(Ded == false)
        {
            GetComponent<NavMeshAgent>().enabled = true;
        }
        //Instantiate(C06, this.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WeponObject"))
        {
            this.gameObject.SendMessage("EnemyDes");
        }
        if (other.gameObject.name == "FPSController")
        {
            other.gameObject.SendMessage("HPcange");
            EnemyDes();
        }
    }

    private void EnemyDes()
    {
        Ded = true;
        GetComponent<NavMeshAgent>().enabled = false;
        animator.SetBool("Hp", true);
        Destroy(C06, 1.83f);
        Destroy(GetComponent<BoxCollider>());
        Destroy(this, 1.83f);
    }
}
