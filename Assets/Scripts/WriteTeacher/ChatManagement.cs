using UnityEngine;
using UnityEngine.UI;

public class ChatManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject _messageBox;

    [SerializeField]
    private Transform _parrentMessageBox;

    [SerializeField]
    protected InputField _inputArea;

    [SerializeField]
    private ConfiguringMessageBox _configuringMessage;

    private WriteTeacherController _writeTeacherController;

    private bool _isSend = false;

    private void Awake()
    {
        _writeTeacherController = FindObjectOfType<WriteTeacherController>();   
    }

    public void SendMessageTeacher()
    {
        if (_inputArea.text.Length > 0)
        {
            _configuringMessage._message.text = _inputArea.text;
            Instantiate(_messageBox,_parrentMessageBox);
            if (_isSend == false)
            {
                _isSend = true;
                _writeTeacherController.Complete(_isSend);
            }
        }

    }
}
