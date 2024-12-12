using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {
    public EnemyHealth playerHealth;
    private Image image;
//指定两张sprite图片
public Sprite[] sprites;
void Start () {
image = GetComponent<Image>();
}

void Update () {
//按1或2切换贴图
    if (playerHealth.currentHealth <= 80)
    {
image.sprite = sprites[0];
}
if (Input.GetKeyDown(KeyCode.Alpha2))
{
image.sprite = sprites[1];
}
}

}
