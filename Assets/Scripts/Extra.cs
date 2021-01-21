using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite xSprite;
    private Sprite circleSprite;
    private Sprite triangleSprite;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        xSprite = Resources.Load<Sprite>("X");
        circleSprite = Resources.Load<Sprite>("Circle");
        triangleSprite = Resources.Load<Sprite>("Triangle");
        rend.sprite = xSprite;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
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

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy") 
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
