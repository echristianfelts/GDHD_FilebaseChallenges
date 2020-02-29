using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _11_ThreeRedCubes : MonoBehaviour
{
    public GameObject[] cubes = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
               
                cubes[i].GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);

            }
        }
    }
}
