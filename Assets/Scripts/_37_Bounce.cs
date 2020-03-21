using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _37_Bounce : MonoBehaviour
{
    public float bounceForce=1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("We are getting some action...");
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("We have been here too long...");
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}
