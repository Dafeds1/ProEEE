using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
