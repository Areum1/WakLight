using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartDirector : MonoBehaviour
{
    GameObject heartGage;
    void Start()
    {
        this.heartGage = GameObject.Find("heart");
    }

    void Update()
    {
        
    }

    public void DecreaseHeart()
    {
        this.heartGage.GetComponent<Image>().fillAmount -= 0.2f;
    }
}
