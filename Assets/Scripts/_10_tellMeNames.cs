using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_tellMeNames : MonoBehaviour
{

    public string[] nameArray = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        foreach (string name in nameArray)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
