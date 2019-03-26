using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HugScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer Rend1;

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        // here, you'd check some property of the "other" object

        if (col.GetComponent<Collider2D>().gameObject.name == "PlayerCharacter")
        {


            Rend1.enabled = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("6. VictoryScene");
            }
        }
    }
}
