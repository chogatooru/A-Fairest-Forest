using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class threescore : MonoBehaviour {

    Text text;
    public static int yscore;
    public static int bscore;
    public static int rscore;

    float timer = 0;
	void Start () {
        yscore = 1;
        bscore = 5;
        rscore = 7;

        text = GetComponent<Text>();
	}
	
	void Update () {
        text.text ="x"+rscore+ "      x"+ bscore + "      x"+yscore;
        if (rscore == 0&& bscore == 0&& rscore == 0)
        {
                timer += Time.deltaTime;
                if (timer >= 3)
                {
                    Application.LoadLevel(10);
                }
        }
       
	}
}
