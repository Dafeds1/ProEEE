using UnityEngine;
using UnityEngine.UI;

public class CheckQuestions : MonoBehaviour
{
    [SerializeField]
    private Toggle[] _rightAnswers;
    [SerializeField]
    private GameObject[] _questions;
    [SerializeField]
    private ToggleGroup[] _allAnswer;
    private int _count = 0;
    private GameObject _parent;

    private GostModel _gostModel;

    private void Awake()
    {
        _gostModel = FindObjectOfType<GostModel>();
    }
    private void Start()
    {
        _parent = _questions[_count];
    }
    public void Check()
    {
        if (_allAnswer[_count].AnyTogglesOn())
        {
            _count++;
            if (_rightAnswers[_count - 1].isOn)
            {
                _gostModel.UpdateRightAnswer();
                NextQuestion();
            }
            else
            {
                _gostModel.UpdateResults();
                NextQuestion();
            }
        } 
    }

    private void NextQuestion()
    {
        if (_count < _questions.Length)
        {
            _parent.SetActive(false);
            _parent = _questions[_count];
            _parent.SetActive(true);
        }
    }
}
