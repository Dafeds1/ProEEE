using UnityEngine;

public class Exit : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
