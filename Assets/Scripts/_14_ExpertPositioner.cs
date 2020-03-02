using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _14_ExpertPositioner : MonoBehaviour
{
    public GameObject _player;
    public GameObject _position_01;
    public GameObject _position_02;
    public GameObject _position_03;
    public float vertOffset = .2f;
    private Vector3 vertOffsetVec;
    private int _case = 0;

    // Start is called before the first frame update
    void Start()
    {
    vertOffsetVec = new Vector3(0, vertOffset, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _case = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _case = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _case = 3;
        }

        switch (_case)
        {
            case 1: //easy
                GameObject newEnemy_01 = Instantiate(_player, _position_01.transform.position + vertOffsetVec, Quaternion.identity);
                _case = 0;
                break;
            case 2: //medium
                GameObject newEnemy_02 = Instantiate(_player, _position_02.transform.position + vertOffsetVec, Quaternion.identity);
                _case = 0;
                break;
            case 3:
                GameObject newEnemy_03 = Instantiate(_player, _position_03.transform.position + vertOffsetVec, Quaternion.identity);
                _case = 0;
                break;
            default:
                break;

        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //_case++;


        //                switch (_case)
        //    {
        //        case 1: //easy
        //            GameObject newEnemy_01 = Instantiate(_player, _position_01.transform.position + vertOffsetVec, Quaternion.identity);
        //            break;
        //        case 2: //medium
        //            GameObject newEnemy_02 = Instantiate(_player, _position_02.transform.position + vertOffsetVec, Quaternion.identity);
        //            break;
        //        case 3:
        //            GameObject newEnemy_03 = Instantiate(_player, _position_03.transform.position + vertOffsetVec, Quaternion.identity);
        //            break;
        //        default:
        //            break;

        //    }

        //}
    }
}
