using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject TextObject;
    Text ScoreText;
    int Point;
    float timePoint;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = TextObject.GetComponent<Text>();
        timePoint = 00000;
    }

    // Update is called once per frame
    void Update()
    {
        timePoint += 100*Time.deltaTime;
        Point = (int)timePoint;
        ScoreText.text = $"score : {Point} pt";
    }
}
