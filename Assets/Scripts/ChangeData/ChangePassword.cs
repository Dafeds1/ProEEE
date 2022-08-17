using UnityEngine;
using UnityEngine.UI;

public class ChangePassword : MonoBehaviour
{
    [SerializeField]
    private InputField _currentPassword;
    [SerializeField]
    private InputField _newPassword;
    [SerializeField]
    private InputField _repeatNewPassword;

    [SerializeField]
    private GameObject _currentObject;

    private ChangeDataModel _changeDataModel;

    private void Awake()
    {
        _changeDataModel = FindObjectOfType<ChangeDataModel>();
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        try
        {
            if (_currentPassword.text.Length > 0 && _newPassword.text.Length > 0 && _repeatNewPassword.text.Length > 0) 
            {
                _changeDataModel.CompletingChangePassword(true);
                ClosingWindow();
            }

        }
        catch (System.Exception error)
        {

            Debug.LogError(error);
        }
        
    }

    public void ClosingWindow()
    {
        _currentObject.SetActive(false);
    }
}
