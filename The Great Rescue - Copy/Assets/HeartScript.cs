using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    [SerializeField]
    private int health;
    public Renderer Rend5;
    public Renderer Rend4;
    public Renderer Rend3;
    public Renderer Rend2;
    public Renderer Rend1;
    public Renderer PRend5;
    public Renderer PRend4;
    public Renderer PRend3;
    public Renderer PRend2;
    public Renderer PRend1;



    // Update is called once per frame
    void Update()
    {
        health = PlayerScript.health;

        if (health >= 5)
        {
            Rend5.enabled = true;
            Rend4.enabled = true;
            Rend3.enabled = true;
            Rend2.enabled = true;
            Rend1.enabled = true;

            PRend5.enabled = true;
            PRend4.enabled = false;
            PRend3.enabled = false;
            PRend2.enabled = false;
            PRend1.enabled = false;


        }
        if (health == 4)
        {
            Rend5.enabled = false;
            Rend4.enabled = true;
            Rend3.enabled = true;
            Rend2.enabled = true;
            Rend1.enabled = true;

            PRend5.enabled = false;
            PRend4.enabled = true;
            PRend3.enabled = false;
            PRend2.enabled = false;
            PRend1.enabled = false;
        }
        

        if (health == 3)
        {
            Rend5.enabled = false;
            Rend4.enabled = false;
            Rend3.enabled = true;
            Rend2.enabled = true;
            Rend1.enabled = true;

            PRend5.enabled = false;
            PRend4.enabled = false;
            PRend3.enabled = true;
            PRend2.enabled = false;
            PRend1.enabled = false;
        }
        if (health == 2)
        {
            Rend5.enabled = false;
            Rend4.enabled = false;
            Rend3.enabled = false;
            Rend2.enabled = true;
            Rend1.enabled = true;

            PRend5.enabled = false;
            PRend4.enabled = false;
            PRend3.enabled = false;
            PRend2.enabled = true;
            PRend1.enabled = false;
        }
        if (health == 1)
        {
            Rend5.enabled = false;
            Rend4.enabled = false;
            Rend3.enabled = false;
            Rend2.enabled = false;
            Rend1.enabled = true;

            PRend5.enabled = false;
            PRend4.enabled = false;
            PRend3.enabled = false;
            PRend2.enabled = false;
            PRend1.enabled = true;

        }
        if (health == 0)
         {
            Rend5.enabled = false;
            Rend4.enabled = false;
            Rend3.enabled = false;
            Rend2.enabled = false;
            Rend1.enabled = false;

            PRend5.enabled = false;
            PRend4.enabled = false;
            PRend3.enabled = false;
            PRend2.enabled = false;
            PRend1.enabled = true;
        }
    }
}
