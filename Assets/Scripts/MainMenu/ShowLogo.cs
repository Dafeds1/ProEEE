using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowLogo : MonoBehaviour
{
    private string _sceneName = "MainMenu";
    // Update is called once per frame
    void Update()
    {
        PressAnyKey();
    }

    public void PressAnyKey()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(_sceneName,LoadSceneMode.Single);
        }
    }
}
