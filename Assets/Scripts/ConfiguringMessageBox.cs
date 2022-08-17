using UnityEngine;
using UnityEngine.UI;

public class ConfiguringMessageBox : MonoBehaviour
{
    [SerializeField]
    private Text _time;

    public Text _message;


    // Start is called before the first frame update
    void Start()
    {
        _time.text = System.DateTime.Now.ToString();
    }

}
