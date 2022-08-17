using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnswer : MonoBehaviour
{
    [SerializeField]
    private CheckQuestions _checkQuestions;
    public void OnCLick()
    {
        _checkQuestions.Check();
    }
}
