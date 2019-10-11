using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTest : MonoBehaviour
{
    private bool getScore = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.1f,0,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (getScore == false)
        {
            if (other.gameObject.CompareTag("Hair") == true)
            {
                Debug.Log("Get Score!");
                GetComponent<SpriteRenderer>().color = Color.red;   
                getScore = true;
            }
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            if (getScore == false)
            {
                Debug.Log("Lose Score!");
            }
            Destroy(gameObject);
        }
    }
}
