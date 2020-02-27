using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _04_QuizScript : MonoBehaviour
{
    public float quiz1 = 0f;
    public float quiz2 = 0f;
    public float quiz3 = 0f;
    public float quiz4 = 0f;
    public float quiz5 = 0f;
    private float _quizTotal;
    private float _quizAvge;
    private int _switchValue;

    private string _letterGrade = "X";


    // Start is called before the first frame update
    void Start()
    {
        QuizReset();
        _quizAvge = Mathf.RoundToInt((quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5);
        SwitchValueCalculator();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            QuizReset();
            _quizAvge = Mathf.RoundToInt((quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5);
            //_quizAvge = Mathf.Round(_quizAvge * 100f) / 100f;
            SwitchValueCalculator();
            GradetoLetterConverter();

            Debug.Log(" The avarage of your grades is "+ _quizAvge + ".  That means your letter Grade is an: "+ _letterGrade+".");
        }

    }

    void QuizReset()
    {
        quiz1 = Mathf.Round(Random.Range(50f, 100f) * 100f) / 100f;

        quiz2 = Mathf.Round(Random.Range(50f, 100f) * 100f) / 100f;
        quiz3 = Mathf.Round(Random.Range(50f, 100f) * 100f) / 100f;
        quiz4 = Mathf.Round(Random.Range(50f, 100f) * 100f) / 100f;
        quiz5 = Mathf.Round(Random.Range(50f, 100f) * 100f) / 100f;

    }

    void SwitchValueCalculator()
    {
        _switchValue = 0;

        if (_quizAvge <90)
        {
            _switchValue = 1;

            if (_quizAvge < 80)
            {
                _switchValue = 2;

                if (_quizAvge < 70)
                {
                    _switchValue = 3;
                    if (_quizAvge < 60)
                    {
                        _switchValue = 4;
                    }
                }
            }
        }

    }

    void GradetoLetterConverter()
    {
        switch (_switchValue)
        {
            case 0: //easy
                _letterGrade = "A";
                Debug.Log("Easy..!");
                break;
            case 1: //medium
                _letterGrade = "B";
                Debug.Log("OK..!");
                break;
            case 2: //hard
                _letterGrade = "C";
                Debug.Log("Achevable..!");
                break;
            case 3: //hard
                _letterGrade = "D";
                Debug.Log("Too Hard..!");
                break;
            case 4: //hard
                _letterGrade = "F";
                Debug.Log("Way Too Hard..!");
                break;
            default:
                Debug.Log("Invalid Selection..!!");
                break;

        }

    }


}
