using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _37_FreezeTime : MonoBehaviour
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
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.01f;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 frames per real-time second
            Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;
        }
    }
}
