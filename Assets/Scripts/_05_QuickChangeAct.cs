using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _05_QuickChangeAct : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 5.5f;
    public float horizontalInput;
    public float verticalInput;



    // Start is called before the first frame update
    void Start()
    {
        //transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovementControl();
    }

    void MovementControl()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        Vector3 playerVector = new Vector3((-1 * horizontalInput), 0 , 0);

        transform.Translate(playerVector * Time.deltaTime * _playerSpeed);
    }


    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);
    }
}


