using UnityEngine;

public class ChatWithTeacherModel : MonoBehaviour
{
    private const string COMPLETE_KEY = "WorkChatCompleted";
    private const int TRUE_NUM = 1;
    private const int FALSE_NUM = 0;

    ChatWithTeacherController _chatWithTeacherController;

    private bool _workChatCompleted
    {
        get => PlayerPrefs.GetInt(COMPLETE_KEY) == TRUE_NUM ? true : false;
        set
        {
            PlayerPrefs.SetInt(COMPLETE_KEY, value == true ? TRUE_NUM : FALSE_NUM);
            PlayerPrefs.Save();
        }
    }

    public bool isComplete => _workChatCompleted;

    private void Awake()
    {
        _chatWithTeacherController = FindObjectOfType<ChatWithTeacherController>();
        ChatWithTeacherController.TaskWasCompleted += CompletingTask;
    }
    private void Start()
    {
        if (_workChatCompleted == true)
        {
            _chatWithTeacherController.Complete(true);
            ChatWithTeacherController.TaskWasCompleted -= CompletingTask;
        }
    }
    private void OnDestroy()
    {
        ChatWithTeacherController.TaskWasCompleted -= CompletingTask;
    }

    public void CompletingTask(bool value)
    {
        _workChatCompleted = value;
    }
}
