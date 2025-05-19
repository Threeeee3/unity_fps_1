using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaitenn : MonoBehaviour
{
    public GameObject aiu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aiu.transform.Rotate(0f, 100.0f * Time.deltaTime, 0f);
    }
}
