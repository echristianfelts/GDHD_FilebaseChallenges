using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _26_MagicTrick : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.I))
        {
            _counterTime = Time.time + 5f;
            //this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            this.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 0f);
        }

        if (_counterTime < Time.time)
        {
            this.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);


        }
    }
}
