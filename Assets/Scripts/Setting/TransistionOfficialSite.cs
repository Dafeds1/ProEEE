using UnityEngine;

public class TransistionOfficialSite : MonoBehaviour
{
    [SerializeField]
    private string _url;

    public void OpenOfficialSite()
    {
        Application.OpenURL(_url);
    }   
}
