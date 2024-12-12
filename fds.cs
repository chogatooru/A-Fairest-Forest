using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fds : MonoBehaviour
{
    public bool entertrigger;
    void Start()
    {
        entertrigger = false;
        GameObject.Find("Cube").AddComponent<MeshCollider>();//球与下面的抽象射线碰撞检测必须  
    }  

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            //GameObject.Find("Zombunny (1)").GetComponent<EnemyMovement>().enabled = true;
            Debug.Log("dfsadsadsa");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//鼠标左键点下  
        {
            //住摄像机向鼠标位置发射射线    
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit mHit;
            //射线检验    
            if (Physics.Raycast(mRay, out mHit))
            {
                if (mHit.collider.gameObject.tag == "flowers")
                {
                    Debug.Log("dfsadsadsa");
                }

            }

        } 

    }
 }
