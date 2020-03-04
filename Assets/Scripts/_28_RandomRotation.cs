using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _28_RandomRotation : MonoBehaviour
{
    [SerializeField]
    private float _counterTime;

    // Start is called before the first frame update
    void Start()
    {
        _counterTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {


            //_counterTime = Time.time + 5f;
            //this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            //this.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);


        if (_counterTime < Time.time)
        {
            Debug.Log("Do we ever get here...?");
            this.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            this.transform.Rotate(0f,Random.Range(0f, 360f), 0f);
            _counterTime = Time.time + 5f;
        }
    }
}
