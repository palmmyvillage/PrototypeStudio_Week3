using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullScore : MonoBehaviour
{
    private bool isReady = false;
    private bool isMissed = false;
    private bool usable = true;
    private AudioSource scream;
    public MyScoreManager myscore;
    public Sprite missedSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        scream = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (usable == false)
        {
            if (scream.isPlaying == false)
                Destroy(gameObject);
        }

        if (isMissed == true && isReady == false)
            GetComponent<SpriteRenderer>().color -= new Color(0,0,0,0.02f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Zone"))
        {
            isReady = true;
            Debug.Log("now Ready");
        }
            

        if (isReady == true && usable == true)
        {
            if (other.gameObject.CompareTag("Hair"))
            {
                myscore.Score++;
                Debug.Log("GetScore");
                scream.Play();
                GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
                Instantiate(Resources.Load("Prefabs/Wagh!"), transform.position,new Quaternion(0,0,0,0));
                usable = false;
            }
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);

            if (usable == true)
            {
                Instantiate(Resources.Load("Prefabs/Miss"), transform.position,new Quaternion(0,0,0,0));
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Zone"))
        {
            if (usable == true)
            {
                isReady = false;
                isMissed = true;
                GetComponent<SpriteRenderer>().sprite = missedSprite;
                Debug.Log("miss");
            }
        }
    }
}
