using UnityEngine;
using UnityEngine.UI;

public class WindowChatManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject _messageBox;

    [SerializeField]
    private Transform _parrentMessageBox;

    [SerializeField]
    protected InputField _inputArea;

    [SerializeField]
    private ConfiguringMessageBox _configuringMessage;

    private ChatWithTeacherController _chatWithTeacherController;

    private bool _isSend = false;

    private void Awake()
    {
        _chatWithTeacherController = FindObjectOfType<ChatWithTeacherController>();
    }

    public void SendMessage()
    {
        if (_inputArea.text.Length > 0)
        {
            _configuringMessage._message.text = _inputArea.text;
            Instantiate(_messageBox, _parrentMessageBox);
            if (_isSend != true)
            {
                _isSend = true;
                _chatWithTeacherController.Complete(_isSend);
            }
        }
        

    }
}
