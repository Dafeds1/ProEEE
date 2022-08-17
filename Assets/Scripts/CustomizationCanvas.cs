using UnityEngine;

public class CustomizationCanvas : MonoBehaviour
{
    private Camera _mainCamera;
    private void Awake()
    {
        _mainCamera = FindObjectOfType<Camera>();
        gameObject.GetComponent<Canvas>().worldCamera = _mainCamera;
    }

}
