﻿using UnityEngine;  
using System.Collections;  
using UnityEngine.UI;

public class EDcode : MonoBehaviour
{
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
        if (Input.GetButtonDown("Fire1")){
            Application.LoadLevel(9);
        }
        if (timer >= 19)
        {
            
            Destroy(image);
            Application.LoadLevel(9);
        }
    }
}
