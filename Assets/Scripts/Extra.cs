﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    protected SpriteRenderer rend;
    private Sprite xSprite;
    private Sprite circleSprite;
    private Sprite triangleSprite;
    protected Sprite circleGreenSprite;
    //private Renderer colorRend;
    //[SerializeField] private Color colorToTurnTo = Color.white;




    protected void Start()
    {
        //colorRend = GetComponent<Renderer>();
        //rend.material.color = colorToTurnTo;
        rend = GetComponent<SpriteRenderer>();
        xSprite = Resources.Load<Sprite>("X");
        circleSprite = Resources.Load<Sprite>("Circle");
        circleGreenSprite = Resources.Load<Sprite>("GreenCircle");
        triangleSprite = Resources.Load<Sprite>("Triangle");
        rend.sprite = xSprite;

    }

    // Update is called once per frame
    protected void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           Debug.Log("Bababooey");
           rend.sprite = circleGreenSprite;
        
        }
    }

    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.tag == "Player") //Update() + Input.GetMouseButtonDown(0)
        {
            if (rend.sprite == xSprite)
            {
                Debug.Log("F");
                rend.sprite = circleSprite;
            }
            else if (rend.sprite == circleSprite)
            {
                Debug.Log("U");
                rend.sprite = triangleSprite;
            }
            else if (rend.sprite == triangleSprite)
            {
                Debug.Log("Too");
                rend.sprite = xSprite;
            }
        }
    }
}
