using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrek : MonoBehaviour
{

    private Vector2 position;
    public float speed;
    private float direction;
    public int health = 5;
    public float time = 5f;
    private float timeelapsed = 0;
    AudioSource m_MyAudioSource;
    public GameObject DeathSound;
    public GameObject DeathParticle;
    public GameObject deathloc;
    private float timex = 0;
    private bool changecolor = false;
    public float colortime = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {



            Destroy(gameObject);
        }
        if (BgScroll.MoveBg == true)
        { Destroy(gameObject); }


        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-200, transform.position.y), speed * Time.deltaTime);
        timeelapsed += Time.deltaTime;
        if (timeelapsed >= time)
        {
            Destroy(gameObject);
        }
        if (health <= 0)
        {

            DeathSound = Instantiate(DeathSound) as GameObject;
            DeathParticle = Instantiate(DeathParticle) as GameObject;
            DeathParticle.transform.position = deathloc.transform.position;
            DeathSound.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
        if (changecolor == true)
        {
            timex += Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
            if (timex >= colortime)
            {
                timex = 0;
                changecolor = false;
                GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "BulletPrefab(Clone)")
        {

            changecolor = true;
            health--;
        }
    }

      





}