using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    protected int points;

    protected SpriteRenderer rend;
    protected Sprite xSprite;
    protected Sprite circleSprite;
    protected Sprite triangleSprite;
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

    }

    protected void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.tag == "Player") //Update() + Input.GetMouseButtonDown(0)
        {
            if (rend.sprite == xSprite)
            {
                points++;
                Debug.Log(points);
                rend.sprite = circleSprite;
            }
            else if (rend.sprite == circleSprite)
            {
                points--;
                Debug.Log(points);
                rend.sprite = triangleSprite;
            }
            else if (rend.sprite == triangleSprite)
            {
                Debug.Log(points);
                rend.sprite = xSprite;
            }
        }
    }
}
