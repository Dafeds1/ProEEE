using UnityEngine;
using UnityEngine.UI;

public class GostView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        GostController.TestWasPassed += SetStatus;
    }

    private void OnDestroy()
    {
        GostController.TestWasPassed -= SetStatus;
    }

    private void SetStatus(bool value)
    {
        
        _stateButton.interactable = value;
        _stateButton.GetComponent<Image>().sprite = _active;
    }

}
