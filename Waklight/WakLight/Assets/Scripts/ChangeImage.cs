using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    Vector3 pos;
    Image m_Image;
    public Sprite m_Sprite1;
    public Sprite m_Sprite2;

    void Start()
    {
        pos = this.gameObject.transform.position;
        m_Image = GetComponent<Image>();
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            m_Image.sprite = m_Sprite1;
        }
        if (Input.GetMouseButtonUp(0))
        {
            m_Image.sprite = m_Sprite2;
        }
    }
}