using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class PlayingVideo : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer _video;
    

    public void OnMouseDown()
    {
        _video.Play();
    }


}
