using UnityEngine;

public class SettingsWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingsWindow;

    public void ShowSettingsWindow()
    {
        Instantiate(_settingsWindow, new Vector3(0f,0f,0f), Quaternion.identity);
    }  
}
