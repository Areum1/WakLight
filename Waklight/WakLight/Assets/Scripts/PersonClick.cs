using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonClick : MonoBehaviour
{
    float MaxDistance = 15f;
    Vector3 MousePosition;
    Camera Camera;
    public Image imgHpBar;

    void Start()
    {
        Camera = GetComponent<Camera>();
        imgHpBar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);

            RaycastHit2D hit = Physics2D.Raycast(MousePosition, transform.forward, MaxDistance);
            Debug.DrawRay(MousePosition, transform.forward * 10, Color.red, 0.3f);
            if (hit)
            {
                hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
                imgHpBar.gameObject.SetActive(true);
            }
        }
    }
}