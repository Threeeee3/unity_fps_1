using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolTime : MonoBehaviour
{
    public Image Cool;
    float countTime;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Cool.fillAmount -= 1.0f / countTime * Time.deltaTime;
    }

    public void reLowding(float CTime)
    {
        Cool.fillAmount = 1;
        countTime = CTime;
    }
}
