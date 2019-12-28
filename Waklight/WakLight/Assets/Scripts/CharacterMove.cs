using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    Vector3 pos;
    int size = 9;

    void Start()
    {
        pos = this.gameObject.transform.position;
        Debug.Log(pos);
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (pos.x > mousePos.x)
        {
            transform.Translate(-size, 0, 0);
        }
        if (pos.x < mousePos.x)
        {
            transform.Translate(size, 0, 0);
        }
        
    }
}