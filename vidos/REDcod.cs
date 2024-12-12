using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class REDcod : MonoBehaviour {

    float timer;
    public MovieTexture movTexture;
    public GameObject image;

    void Start()
    {
        //设置电影纹理播放模式为循环  

        movTexture.Play();
        RawImage ri = gameObject.GetComponent<RawImage>();
        ri.texture = movTexture;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 10)
        {

            Destroy(image);
            Application.LoadLevel(9);
        }
    }
}
