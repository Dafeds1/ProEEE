using UnityEngine;

public class ChangeDataModel : MonoBehaviour
{
    private const string COMPLETE_KEY = "ChangeDataCompleted";
    private const int TRUE_NUM = 1;
    private const int FALSE_NUM = 0;
    private bool _isPasswordChange;
    private bool _isInfoEdited;

    ChangeDataController _changeDataController;


    private bool _changeDataCompleted
    {
        get => PlayerPrefs.GetInt(COMPLETE_KEY) == TRUE_NUM? true : false;
        set
        {
            PlayerPrefs.SetInt(COMPLETE_KEY, value == true ? TRUE_NUM : FALSE_NUM);
            PlayerPrefs.Save();
        }
    } 

    private void Awake()
    {
        _changeDataController = FindObjectOfType<ChangeDataController>();
        ChangeDataController.TaskWasCompleted += CompletingTask;   
    }
    private void Start()
    {
        if (_changeDataCompleted == true)
        {
            _changeDataController.Complete(true);
            ChangeDataController.TaskWasCompleted -= CompletingTask;
        }
    }
    private void OnDestroy()
    {
        ChangeDataController.TaskWasCompleted -= CompletingTask;
    }

    public void CompletingChangePassword(bool isCompleteChangePassword)
    {
        _isPasswordChange = isCompleteChangePassword;
        if (_isInfoEdited == true)
        {
            _changeDataController.Complete(isCompleteChangePassword);
        }
    }

    public void CompletingEditInfo(bool isCompleteEditInfo)
    {
        _isInfoEdited = isCompleteEditInfo;
        if (_isPasswordChange == true)
        {
            _changeDataController.Complete(isCompleteEditInfo);
        }
    }

     public void CompletingTask(bool value)
    {
        _changeDataCompleted = value;
    }
}
