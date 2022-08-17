using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _desktops;
    [SerializeField]
    private GameObject _coursesList;
    [SerializeField]
    private GameObject _course;
    [SerializeField]
    private GameObject _logInChat;
    [SerializeField]
    private GameObject _windowChat;

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

    public void LogInToChat()
    {
        _course.SetActive(false);
        _logInChat.SetActive(true);
    }

    public void OpenChat()
    {
        _logInChat.SetActive(false);
        _windowChat.SetActive(true);
    }
}
