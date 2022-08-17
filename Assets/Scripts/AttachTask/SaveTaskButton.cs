using UnityEngine;

public class SaveTaskButton : MonoBehaviour
{
    [SerializeField]
    private CheckOnCollision _checkOnCollision;
    AttachTaskController _attachTaskController;

    private void Awake()
    {
        _attachTaskController = FindObjectOfType<AttachTaskController>();
    }

    public void OnClick()
    {
        Debug.Log(_checkOnCollision.isLoad);
        if (_checkOnCollision.isLoad == true)
        {
            _attachTaskController.Complete(_checkOnCollision.isLoad);
        }
    }
}
