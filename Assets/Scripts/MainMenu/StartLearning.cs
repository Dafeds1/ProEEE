using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLearning : MonoBehaviour
{
    [SerializeField]
    private string _sceneName;

    public void Learning()
    {
        SceneManager.LoadScene(_sceneName, LoadSceneMode.Single);            
    }
}
