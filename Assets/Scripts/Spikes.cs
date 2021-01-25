using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : Extra
{
    private SpriteRenderer rend;
    private Sprite spikeSprite;
    private Sprite noSpikeSprite;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        spikeSprite = Resources.Load<Sprite>("Spike");
        noSpikeSprite = Resources.Load<Sprite>("noSpike");
        rend.sprite = spikeSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(rend.sprite = circleGreenSprite)
        {
            Debug.Log("Not that");
            rend.sprite = noSpikeSprite;
        }
    }
}
