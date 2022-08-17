using UnityEngine;
using UnityEngine.UI;

public class WriteTeacherView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        WriteTeacherController.TaskWasCompleted += SetStatus;
    }

    private void OnDestroy()
    {
        WriteTeacherController.TaskWasCompleted -= SetStatus;
    }

    private void SetStatus(bool isComlete)
    {
        _stateButton.interactable = isComlete;
        _stateButton.GetComponent<Image>().sprite = _active;

    }
}
