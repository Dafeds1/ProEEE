using UnityEngine;
using UnityEngine.EventSystems;

public class MovementIcon : MonoBehaviour, IBeginDragHandler,IDragHandler
{
    private Vector3 _currentMousePosition;
    private Vector3 _lastMousePosition;
    private const float _speedMouse = 30f; 
    private RectTransform _rectTransform;
    [SerializeField]
    CheckOnCollision _checkOnCollision;
    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        _lastMousePosition = Camera.main.ScreenToWorldPoint(eventData.position);
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (_checkOnCollision.isLoad == false)
        {
            _currentMousePosition = Camera.main.ScreenToWorldPoint(eventData.position); 
            Vector2 difference = _currentMousePosition - _lastMousePosition;
            Vector3 newPosition = _rectTransform.localPosition + new Vector3(difference.x * _speedMouse,difference.y * _speedMouse, 0f);
            _rectTransform.localPosition = new Vector3(newPosition.x, newPosition.y, transform.localPosition.z);
            _lastMousePosition = _currentMousePosition;
        }
    }
}
