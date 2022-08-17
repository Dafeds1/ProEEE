using UnityEngine;
using UnityEngine.UI;

public class EditInfo : MonoBehaviour
{
    [SerializeField]
    private InputField _email;

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
            if (_email.text.Length > 0)
            {
                _changeDataModel.CompletingEditInfo(true);
                ClosingWindow();
            }
        }
        catch (System.Exception error)
        {

           Debug.LogError(error) ;
        }
    }

    public void ClosingWindow()
    {
        _currentObject.SetActive(false);
    }

}
