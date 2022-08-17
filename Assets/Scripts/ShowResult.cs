using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    [SerializeField]
    private Text _result;
    private float _resultPercentage;
    GostModel _gostModel;
    private void Awake()
    {
        _gostModel = FindObjectOfType<GostModel>();        
    }

    void Start()
    {
        Show();    
    }

    private void Show()
    {
        _resultPercentage = _gostModel.Progress;
        _result.text = "Ваш результат: " + _resultPercentage.ToString() + "%";
    }

}
