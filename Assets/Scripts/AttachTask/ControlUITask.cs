using UnityEngine;


public class ControlUITask : MonoBehaviour
{
    [SerializeField]
    private GameObject _desktops;
    [SerializeField]
    private GameObject _coursesList;
    [SerializeField]
    private GameObject _course;
    [SerializeField]
    private GameObject _attachTask;
    [SerializeField]
    private GameObject _formTask;

    public void ShowCorsesList()
    {
        _desktops.SetActive(false);
        _coursesList.SetActive(true);
    }

    public void GoToCourse()
    {
        _coursesList.SetActive(false);
        _course.SetActive(true);
    }

    public void GoToTask()
    {
        _course.SetActive(false);
        _attachTask.SetActive(true);
    }

    public void OpenFormTask()
    {
        _attachTask.SetActive(false);
        _formTask.SetActive(true);
    }
}
