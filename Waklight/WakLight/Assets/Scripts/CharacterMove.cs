using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    Vector3 pos;
    int size = 9;
    Image m_Image;
    public Sprite m_Sprite1;
    public Sprite m_Sprite2;

    void Start()
    {
        pos = this.gameObject.transform.position;
        Debug.Log(pos);
        m_Image = GetComponent<Image>();
    }
    
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            m_Image.sprite = m_Sprite1;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_Image.sprite = m_Sprite2;
        }

        else
        {
            Debug.Log("나 마우스 아무것도 안하는 중");
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
}