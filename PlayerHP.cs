using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int PlayHP;
    public GameObject HP1;
    public GameObject HP2;
    // Start is called before the first frame update
    void Start()
    {
        PlayHP = 3;
        HP1.SetActive(false);
        HP2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HPcange()
    {
        PlayHP--;
        if(PlayHP == 0)
        {
            SceneManager.LoadScene("Game over");
        }
        if(PlayHP == 1)
        {
            HP1.SetActive(true);
        }
        if(PlayHP == 2)
        {
            HP2.SetActive(true);
        }
    }
}
