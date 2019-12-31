using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokGenerator : MonoBehaviour
{
    public GameObject Prefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Prefab) as GameObject;
            int px = Random.Range(-100, 100);
            go.transform.position = new Vector3(px, -200, 0);
        }
    }
}
