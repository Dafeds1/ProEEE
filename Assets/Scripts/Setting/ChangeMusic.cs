using UnityEngine;
using UnityEngine.Audio;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    public void ChangingVolumeMusic(float musicLevel)
    {
        _audioMixer.SetFloat("Music", musicLevel);
    }
}
