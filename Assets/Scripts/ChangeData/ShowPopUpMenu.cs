using UnityEngine;

public class ShowPopUpMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _popUpMenu;
    [SerializeField]
    private GameObject _settings;
    [SerializeField]
    private GameObject _editedInfo;
    [SerializeField]
    private GameObject _changedPassword;

    public void OpenPopUpMenu()
    {
        _popUpMenu.SetActive(true);
    }

    public void OpenSettings()
    {
        _popUpMenu.SetActive(false);
        _settings.SetActive(true);
    }
    
    public void OpenEditedInfo()
    {
        _settings.SetActive(false);
        _editedInfo.SetActive(true);
    }

    public void OpenChangedPassword()
    {
        _settings.SetActive(false);
        _changedPassword.SetActive(true);
    }
}
