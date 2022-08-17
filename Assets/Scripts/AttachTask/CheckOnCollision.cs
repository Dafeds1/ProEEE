using UnityEngine;
using UnityEngine.UI;

public class CheckOnCollision : MonoBehaviour
{
    [SerializeField]
    private Image _icon;
    public bool isLoad = false;

    public void TriggerEnter()
    {
        isLoad = true;
        _icon.transform.SetParent(gameObject.transform);
        _icon.rectTransform.anchorMin = new Vector2(0f,0.5f);
        _icon.rectTransform.anchorMax = new Vector2(0f,0.5f);
        _icon.rectTransform.anchoredPosition = new Vector2(_icon.rectTransform.rect.width * 0.5f, 0f);
    }


}
