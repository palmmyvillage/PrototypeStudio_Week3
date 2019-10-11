﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUp : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().color -= new Color(0,0,0,0.04f);
        
        if (GetComponent<SpriteRenderer>().color.a <= 0)
            Destroy(gameObject);
        
        transform.position += new Vector3(0,0.02f,0);
        
    }
}
