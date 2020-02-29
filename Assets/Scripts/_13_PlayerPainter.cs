using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _13_PlayerPainter : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    private float _playerSpeed=3f;
    private float _timerTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 playerVector = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(playerVector * Time.deltaTime * _playerSpeed);
        if (horizontalInput !=0 || verticalInput != 0)
        {
            if (_timerTime < Time.time)
            {
                _timerTime = Time.time + .05f;
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = this.transform.position - new Vector3(0, 0.5f, 0);
                sphere.transform.localScale = new Vector3(.25f, .05f, .25f);
                sphere.GetComponent<Renderer>().material.color = Color.red;
            }

        }
    }
}
