using UnityEngine;
using UnityEngine.UI;

public class AttachTaskView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        AttachTaskController.TaskWasCompleted += SetStatus;
    }

    private void OnDestroy()
    {
        AttachTaskController.TaskWasCompleted -= SetStatus;
    }

    private void SetStatus(bool isComlete)
    {
        _stateButton.interactable = isComlete;
        _stateButton.GetComponent<Image>().sprite = _active;

    }
}
