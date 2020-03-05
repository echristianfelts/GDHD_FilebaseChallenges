using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _31_ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            this.GetComponent<Renderer>().material.color = Color.red;


        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            this.GetComponent<Renderer>().material.color = Color.blue;

        }
    }
}
