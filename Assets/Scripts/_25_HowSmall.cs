using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _25_HowSmall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.localScale = this.transform.localScale * .5f;
        }
    }
}
