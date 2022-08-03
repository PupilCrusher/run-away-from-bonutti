using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachter : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal =speed * Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime, 0, 0);

    }
}
