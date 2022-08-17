using UnityEngine;

public class WriteTeacherModel : MonoBehaviour
{
    private const string COMPLETE_KEY = "WriteTeacherCompleted";
    private const int TRUE_NUM = 1;
    private const int FALSE_NUM = 0;

    WriteTeacherController _writeTeacherController;

    private bool _writeTeacherCompleted
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
        _writeTeacherController = FindObjectOfType<WriteTeacherController>();
        WriteTeacherController.TaskWasCompleted += CompletingTask;
    }
    private void Start()
    {
        if (_writeTeacherCompleted == true)
        {
            _writeTeacherController.Complete(true);
            WriteTeacherController.TaskWasCompleted -= CompletingTask;
        }
    }
    private void OnDestroy()
    {
        WriteTeacherController.TaskWasCompleted -= CompletingTask;
    }

    public void CompletingTask(bool value)
    {
        _writeTeacherCompleted = value;
    }
}
