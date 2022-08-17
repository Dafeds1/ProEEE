using UnityEngine;
using UnityEngine.UI;

public class AddQuestionButton : MonoBehaviour
{
    [SerializeField]
    private InputField _theme;
    [SerializeField]
    private InputField _message;

    WorkOnForumController _workOnForumController;

    private void Awake()
    {
        _workOnForumController = FindObjectOfType<WorkOnForumController>();
    }

    public void OnClick()
    {
        if (_theme.text.Length > 0 && _message.text.Length > 0)
        {
            _workOnForumController.Complete(true);
        }
    }
}
