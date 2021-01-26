using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : SpikesScript
{
    private SpriteRenderer but;
    private Sprite buttonUp;
    private Sprite buttonDown;

    // Start is called before the first frame update
    void Start()
    {
        but = GetComponent<SpriteRenderer>();
        buttonUp = Resources.Load<Sprite>("ButtonUp");
        buttonDown = Resources.Load<Sprite>("ButtonDown");
        but.sprite = buttonUp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnTriggerEnter2D(Collider2D collision2D)
    {
        //Button + Spikes
        if (collision2D.gameObject.tag == "Player")
        {
            but.sprite = buttonDown;
            Debug.Log("Almost");
            if (points == 1)
            {
                Debug.Log("Not that");
                rend.sprite = circleGreenSprite;
                ram.sprite = noSpikeSprite;
            }
            else
            {
                rend.sprite = xSprite;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        but.sprite = buttonUp;
    }
}
