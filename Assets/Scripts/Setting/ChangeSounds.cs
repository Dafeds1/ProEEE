using UnityEngine;
using UnityEngine.Audio;

public class ChangeSounds : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    public void ChangingVolumeSounds(float soundLevel)
    {
        _audioMixer.SetFloat("Sounds", soundLevel);        
    }       
}
