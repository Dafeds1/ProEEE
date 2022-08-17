using UnityEngine;
using UnityEngine.UI;

public class ChangeDataView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        ChangeDataController.TaskWasCompleted += SetStatus;
    }

    private void OnDestroy()
    {
        ChangeDataController.TaskWasCompleted -= SetStatus;
    }

    private void SetStatus(bool isComlete)
    {
        _stateButton.interactable = isComlete;
        _stateButton.GetComponent<Image>().sprite = _active;

    }
}
