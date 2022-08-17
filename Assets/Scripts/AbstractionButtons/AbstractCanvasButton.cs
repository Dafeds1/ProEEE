using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class AbstractCanvasButton : MonoBehaviour
{
    [SerializeField]
    private GameObject _currentCanvas;
    [SerializeField]
    private GameObject _nextCanvas;
    [SerializeField]
    private GameObject _backCanvas;

    

    public GameObject CurrentCanvas => _currentCanvas;
    public GameObject NextCanvas => _nextCanvas;
    public GameObject BackCanvas => _backCanvas;

    protected bool _isNext;
    protected ButtonState _buttonStates;
    /// <summary>
    /// вейк выполнится для любого наследника
    /// </summary>
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnCLick);
    }

    public abstract void OnCLick();
    /// <summary>
    /// Твой метод который можно вызвать если наследоваться от класса, protected не должен по идее позволять вызывать его из стороннего класса не наследника
    /// </summary>
    /// <param name="currentCanvas"></param>
    /// <param name="isNext"></param>
    /// <param name="nextCanvas"></param>
    /// <param name="backCanvas"></param>
    protected void ChangeCanvas(GameObject currentCanvas, bool isNext, GameObject nextCanvas, GameObject backCanvas)
    {
        Instantiate(currentCanvas = isNext? nextCanvas : backCanvas, new Vector3(0f,0f,0f), Quaternion.identity);
        Destroy(_currentCanvas);
        
    }
}

public enum ButtonState
{
    Active,
    NotActive
}