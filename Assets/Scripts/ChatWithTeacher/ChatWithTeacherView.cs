using UnityEngine;
using UnityEngine.UI;

public class ChatWithTeacherView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        ChatWithTeacherController.TaskWasCompleted += SetStatus;
    }

    private void OnDestroy()
    {
        ChatWithTeacherController.TaskWasCompleted -= SetStatus;
    }

    private void SetStatus(bool isComlete)
    {
        _stateButton.interactable = isComlete;
        _stateButton.GetComponent<Image>().sprite = _active;

    }
}
