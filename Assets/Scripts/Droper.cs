using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody RB;
    public float timeToWait = 0f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        RB = GetComponent<Rigidbody>();
        RB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            //Debug.Log("Udah 3 Deitk");
            renderer.enabled = true;
            RB.useGravity = true;
        }
        
    }
}
