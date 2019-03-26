using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBox : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public GameObject hurtbox;
    public float time = 4.0f;
    private float timeactual;

    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        timeactual = time;
    }

    // Update is called once per frame
    void Update()
    {
        timeactual -= Time.deltaTime;
        
       
        if (timeactual <= 2.0f)
        {
            
            SendMessageUpwards("chargingup");
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
           
        }
        if (timeactual <= 1.8f)
        {
            
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            

        }
        if (timeactual <= 1.3f)
        {

            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);

        }
        if (timeactual <= 0.8f)
        {

            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(false);

        }
        if (timeactual <= 0.4f)
        {

            gameObject.transform.GetChild(4).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(false);

        }


        if (timeactual <= 0.0f)
        {
            SendMessageUpwards("shootingup");
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            var hurtboxob = (GameObject)Instantiate(hurtbox);
            hurtboxob.transform.position = gameObject.transform.position;
            hurtboxob.transform.parent = gameObject.transform;

            timeactual = time;
        }

    }
}
