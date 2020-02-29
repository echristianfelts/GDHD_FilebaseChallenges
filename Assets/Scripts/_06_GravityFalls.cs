using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _06_GravityFalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Is this working...?");
        //Player playerTest = other.transform.GetComponent<Player>();
        other.GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);
        Destroy(this.gameObject);
    }
}
