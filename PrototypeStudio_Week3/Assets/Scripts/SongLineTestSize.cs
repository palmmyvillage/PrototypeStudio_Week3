using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongLineTestSize : MonoBehaviour
{
    private SpriteRenderer thisSprite;
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Debug.Log(thisSprite.size);

        speed = (thisSprite.size.x * 25.77f * Time.deltaTime) / 60;
        transform.position += new Vector3(speed,0,0);

        if (GetComponent<AudioSource>().isPlaying == false)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
