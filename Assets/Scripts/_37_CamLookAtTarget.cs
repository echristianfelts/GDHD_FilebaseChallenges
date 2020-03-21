using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _37_CamLookAtTarget : MonoBehaviour
{
    public GameObject _lookAtTarget;
    private GameObject _camRoot;
    public float _rootRotSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //_camRoot = GameObject.Find("CameraRoot");
    }

    // Update is called once per frame
    void Update()
    {
        //_camRoot.transform.Rotate(0f, 1f * _rootRotSpeed, 0f);
        Vector3 directionToFace = _lookAtTarget.transform.position - transform.position;
        //Debug.DrawRay(transform.position, directionToFace, Color.green);

        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = targetRotation;

    }
}
