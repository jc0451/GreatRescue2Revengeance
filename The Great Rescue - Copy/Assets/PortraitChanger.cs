using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitChanger : MonoBehaviour
{
    public Sprite Health5;
    public Sprite Health4;
    public Sprite Health3;
    public Sprite Health2;
    public Sprite Health1;
    private int health;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        health = PlayerScript.health;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        health = PlayerScript.health;

        if (health == 5)
        {
            spriteRenderer.sprite = Health5;

        }

        if (health == 4)
        {
            spriteRenderer.sprite = Health4;

        }

        if (health == 3)
        {
            spriteRenderer.sprite = Health3;

        }

        if (health == 2)
        {
            spriteRenderer.sprite = Health2;

        }

        if (health == 1)
        {
            spriteRenderer.sprite = Health1;

        }

    }
}
