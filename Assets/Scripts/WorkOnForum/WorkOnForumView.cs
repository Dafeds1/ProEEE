using UnityEngine;
using UnityEngine.UI;

public class WorkOnForumView : MonoBehaviour
{
    [SerializeField]
    private Button _stateButton;
    [SerializeField]
    private Sprite _active;

    private void Awake()
    {
        WorkOnForumController.TaskWasCompleted += SetStatus;
    }

    private void OnDestroy()
    {
        WorkOnForumController.TaskWasCompleted -= SetStatus;
    }

    private void SetStatus(bool isComlete)
    {
        _stateButton.interactable = isComlete;
        _stateButton.GetComponent<Image>().sprite = _active;

    }
}
