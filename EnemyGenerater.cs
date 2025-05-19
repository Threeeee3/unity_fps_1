using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float interval;
    private float time;
    private float time2;
    private float Xtime;
    private int i;
    GameObject[] Pop;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        time2 = 0f;
        Xtime = 60f;
        i = 0;
        interval = 5f;
        Pop = GameObject.FindGameObjectsWithTag("Pop");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;


        if (time > interval)
        {
            Instantiate(enemyPrefab, Pop[i].transform.position +new Vector3(0, 13.188f, 0), Quaternion.identity);
            i += 1;
            time = 0f;
        }
        if (time2 > Xtime)
        {
            interval -= 0.25f;
            Xtime += 15f;
        }
    }
}
