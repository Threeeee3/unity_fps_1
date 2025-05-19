using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    
    public float Dis;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posP = Player.transform.position;
        Vector3 posE = Enemy.transform.position;
        Dis = Vector3.Distance(posP, posE);
        animator.SetFloat("EnemyDistance", Dis);
        if(Dis >= 20)
        {
            Enemy.GetComponent<EnemyNavigater>().SpeedChange(3.0f);
        }
        else
        {
            Enemy.GetComponent<EnemyNavigater>().SpeedChange(6.0f);
        }
    }
}
