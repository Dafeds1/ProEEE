using UnityEngine;
using UnityEngine.UI;

public class TransistionCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject _currentCanvas;
    [SerializeField]
    private GameObject _nextCanvas;
    [SerializeField]
    private GameObject _backCanvas;

    [SerializeField]
    private Sprite _notAvtive;

    private bool _isNext;


    public void ClickNext()
    {  
        _isNext = true;
        if (gameObject.GetComponentInChildren<Image>().sprite != _notAvtive)
        {
            ChangeCanvas(_currentCanvas, _isNext, _nextCanvas, _backCanvas);
        }
    }

    public void ClickBack()
    {
        if (gameObject.GetComponentInChildren<Image>().sprite != _notAvtive)
        {
            ChangeCanvas(_currentCanvas, _isNext, _nextCanvas, _backCanvas);
        }
    }

    private void ChangeCanvas(GameObject currentCanvas, bool isNext, GameObject nextCanvas, GameObject backCanvas)
    {
        Destroy(_currentCanvas);
        Instantiate(currentCanvas = isNext? nextCanvas : backCanvas, new Vector3(0f,0f,0f), Quaternion.identity);
    }

}
