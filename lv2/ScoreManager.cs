using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;


    Text text;


    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }


    void Update()
    {
        if (score == 120)
        {
            Application.LoadLevel(10);
        }
        text.text = "Fairies: " + score;
    }
}