using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTEst : MonoBehaviour
{
    private Vector3 mousePrevPosition;
    private Vector3 mouseNewPosition;
    private Vector3 mouseMovement;
    private Rigidbody2D spring;

    // Start is called before the first frame update
    void Start()
    {
        spring = GameObject.Find("Spring").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        mousePrevPosition = Input.mousePosition;
        //Debug.Log("mousePrePos is " + mousePrevPosition);
    }

    private void OnMouseDrag()
    {
        mouseNewPosition = Input.mousePosition;
        //Debug.Log("mousePrePos is " + mousePrevPosition);
        //Debug.Log("mouseNewPos is " + mouseNewPosition);
        mouseMovement = mouseNewPosition - mousePrevPosition;

        spring.transform.position += new Vector3(0,mouseMovement.y*0.005f,0);

        mousePrevPosition = Input.mousePosition;
    }
}
