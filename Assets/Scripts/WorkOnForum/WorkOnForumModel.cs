using UnityEngine;

public class WorkOnForumModel : MonoBehaviour
{
    private const string COMPLETE_KEY = "AddQuestionCompleted";
    private const int TRUE_NUM = 1;
    private const int FALSE_NUM = 0;

    WorkOnForumController _workOnForumController;

    private bool _questionAdded
    {
        get => PlayerPrefs.GetInt(COMPLETE_KEY) == TRUE_NUM ? true : false;
        set
        {
            PlayerPrefs.SetInt(COMPLETE_KEY, value == true ? TRUE_NUM : FALSE_NUM);
            PlayerPrefs.Save();
        }
    }

    private void Awake()
    {
        _workOnForumController = FindObjectOfType<WorkOnForumController>();
        WorkOnForumController.TaskWasCompleted += CompletingTask;
    }
    private void Start()
    {
        if (_questionAdded == true)
        {
            _workOnForumController.Complete(true);
            WorkOnForumController.TaskWasCompleted -= CompletingTask;
        }
    }
    private void OnDestroy()
    {
        WorkOnForumController.TaskWasCompleted -= CompletingTask;
    }

    public void CompletingTask(bool value)
    {
        _questionAdded = value;
    }
}
