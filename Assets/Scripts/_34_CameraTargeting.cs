using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _34_CameraTargeting : MonoBehaviour
{
    [SerializeField]
    GameObject _lookAtTarget;
    float _initX;
    float _deltaX;
    float _initZ;
    float _deltaZ;

    //private GameObject _camRoot;
    public float _rootRotSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        _initX = this.transform.position.x - _lookAtTarget.transform.position.x;
        _initZ = this.transform.position.z - _lookAtTarget.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float newXPos = _lookAtTarget.transform.position.x + _initX;
        float newZPos = _lookAtTarget.transform.position.z + _initZ;
        this.transform.position = new Vector3(newXPos, this.transform.position.y, newZPos);

        //Rotation
        this.transform.Rotate(0f, 1f * _rootRotSpeed, 0f);
        Vector3 directionToFace = _lookAtTarget.transform.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = targetRotation;
    }
}
