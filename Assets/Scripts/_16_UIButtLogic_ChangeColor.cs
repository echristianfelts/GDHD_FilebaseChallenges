using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _16_UIButtLogic_ChangeColor : MonoBehaviour
{
    public GameObject[] cubes = new GameObject[1];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCubeColor()
    {
        cubes[0] = GameObject.Find("TestCube");
        if (cubes[0] == null)
        {
            Debug.Log("NULL Positive");
        }
        else
        {
            cubes[0].GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("NULL Negative");
        }
    }
}
