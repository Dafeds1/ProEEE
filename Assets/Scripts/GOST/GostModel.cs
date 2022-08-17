using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GostModel : MonoBehaviour
{
    private int _rightAnswer = 0;
    [SerializeField]
    private int _totalQuestions = 8;
    private int _leftQuestions;
    private float _progress;   //As a percentage
    public float Progress => _progress;

    private GostController _gostController;

    private void Awake()
    {
        _gostController = FindObjectOfType<GostController>();
        _leftQuestions = _totalQuestions;
    }

    public void UpdateRightAnswer()
    {
        _rightAnswer += 1;
        UpdateResults();
        
    }

    public void UpdateResults()
    {
        if (_leftQuestions != 1)
        {
            _leftQuestions--;
        }
        else 
        {
            _progress = (_rightAnswer / _totalQuestions) * 100;
            _gostController.Passed(true);
        }

    }
}
