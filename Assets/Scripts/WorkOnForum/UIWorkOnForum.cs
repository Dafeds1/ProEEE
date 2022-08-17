using UnityEngine;

public class UIWorkOnForum : MonoBehaviour
{
    [SerializeField]
    private GameObject _desktops;
    [SerializeField]
    private GameObject _coursesList;
    [SerializeField]
    private GameObject _course;
    [SerializeField]
    private GameObject _addedTheme;
    [SerializeField]
    private GameObject _form;

    private bool _formIsShow = false;

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

    public void GoToAddedTheme()
    {
        _course.SetActive(false);
        _addedTheme.SetActive(true);
    }

    public void ShowForm()
    {
        if (_formIsShow != true)
        {
            _formIsShow = true;
            _form.SetActive(_formIsShow);
        }
        else
        {
            _formIsShow = false;
            _form.SetActive(_formIsShow);
        }
    }
}
