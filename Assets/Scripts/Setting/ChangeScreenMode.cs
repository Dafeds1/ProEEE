using UnityEngine;
using UnityEngine.UI;

public class ChangeScreenMode : MonoBehaviour
{
    [SerializeField]
    private Toggle _toggleFullScreen;

    public void ChangingScreenMode()
    {
        Screen.fullScreen = _toggleFullScreen.isOn;
    }
}
