using UnityEngine;

public class AttachTaskModel : MonoBehaviour
{
    private const string COMPLETE_KEY = "AttachTaskCompleted";
    private const int TRUE_NUM = 1;
    private const int FALSE_NUM = 0;

    AttachTaskController _attachTaskController;

    private bool _taskAttached 
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
        _attachTaskController = FindObjectOfType<AttachTaskController>();
        AttachTaskController.TaskWasCompleted += CompletingTask;
    }
    private void Start()
    {
        if (_taskAttached == true)
        {
            _attachTaskController.Complete(true);
            AttachTaskController.TaskWasCompleted -= CompletingTask;
        }
    }
    private void OnDestroy()
    {
        AttachTaskController.TaskWasCompleted -= CompletingTask;
    }

    public void CompletingTask(bool value)
    {
        _taskAttached = value;
    }
}
