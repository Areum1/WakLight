using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    Vector3 pos;
    float size = 5f;
    void Start()
    {
        pos = this.gameObject.transform.position;
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (mousePos.x > 303)
        {
            transform.Translate(-size, 0, 0);
        }
        if(mousePos.x < 303)
        {
            transform.Translate(size, 0, 0);
        }
    }
}