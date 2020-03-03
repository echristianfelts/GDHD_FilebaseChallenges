using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _15_ApplyColorChange : MonoBehaviour
{
    public GameObject cubeLeft;
    public GameObject cubeRight;


    // Start is called before the first frame update
    void Start()
    {
        cubeLeft.GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeRight.GetComponent<Renderer>().material.color = cubeLeft.GetComponent<Renderer>().material.color;
        }
    }
}
