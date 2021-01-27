using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : Counter
{
    private GameObject pog;
    public bool useBool = false;
    public SpriteRenderer rend;
    public Sprite xSprite;
    public Sprite circleSprite;
    public Sprite triangleSprite;
    public Sprite circleGreenSprite;
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
                rend.sprite = circleSprite;
            }
            else if (rend.sprite == circleSprite)
            {
                rend.sprite = triangleSprite;
            }
            else if (rend.sprite == triangleSprite)
            {
                rend.sprite = xSprite;
            }
        }
    }
}
