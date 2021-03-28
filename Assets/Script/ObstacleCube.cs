using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCube : MonoBehaviour
{
    public bool isBlindPlayer;
    private Color idlelColor;
    private Color blindColor;
    // Start is called before the first frame update
    void Start()
    {
        isBlindPlayer = false;
        idlelColor = transform.GetComponent<Renderer>().material.color;
        blindColor = idlelColor;
        blindColor.a = 0.2f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isBlindPlayer)
        {
            Debug.Log("isHit");
            transform.GetComponent<Renderer>().material.color = blindColor;
        }
        else
            transform.GetComponent<Renderer>().material.color = idlelColor;
        isBlindPlayer = false;

        
    }
}
