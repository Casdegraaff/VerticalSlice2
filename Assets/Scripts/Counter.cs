using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int points;
    public bool pointBool = false;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(points);
    }
    protected void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.tag == "PuzzlePieces")
        {
            points++;
        }
        if (collision2D.gameObject.tag == "Button" && points >= 16)
        {
            points = 0;
        
        }
        if (collision2D.gameObject.tag == "Button" && points <= 14)
        {
            points = 0;
        }
        if (points == 15)
        {
            pointBool = true;
        }
        else if(points <= 14 || points >= 16)
        {
            pointBool = false;
        }
    }
}
