using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : Extra
{
    private SpriteRenderer ram;
    private Sprite spikeSprite;
    private Sprite noSpikeSprite;

    // Start is called before the first frame update
    void Start()
    {
        ram = GetComponent<SpriteRenderer>();
        spikeSprite = Resources.Load<Sprite>("Spike");
        noSpikeSprite = Resources.Load<Sprite>("noSpike");
        ram.sprite = spikeSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (rend.sprite == circleGreenSprite)
        {
            Debug.Log("Not that");
            ram.sprite = noSpikeSprite;
        }
    }
}
