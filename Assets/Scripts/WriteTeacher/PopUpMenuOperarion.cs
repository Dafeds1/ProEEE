using UnityEngine;
using UnityEngine.UI;

public class PopUpMenuOperarion : MonoBehaviour
{
    [SerializeField]
    private GameObject _searchResult;

    [SerializeField]
    private GameObject _chat;

    [SerializeField]
    private GameObject _searchEngine;

    [SerializeField]
    private InputField _searchField;

    [SerializeField]
    private Text _nameTeacher;

    [SerializeField]
    private Text _nameTeacherInChat;
    public void ShowPopUpMenu()
    {
        _searchEngine.SetActive(true);
    }

    public void ShowResult()
    {
        _searchResult.SetActive(true);
        _nameTeacher.text = _searchField.text;
        _nameTeacherInChat.text = _searchField.text;
    }

    public void OpenChat()
    {
        _searchResult.SetActive(false);
        _chat.SetActive(true);

    }
}
