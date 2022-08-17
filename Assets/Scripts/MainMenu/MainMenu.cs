using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string _nameMenu = "MainMenu";
     public void ExitToMenu()
    {
        SceneManager.LoadScene(_nameMenu, LoadSceneMode.Single);
    }

    public void CompletionLearning()
    {
        ExitToMenu();
        PlayerPrefs.DeleteAll();
    }
}
