using System;
using UnityEngine;

public class AttachTaskController : MonoBehaviour
{
    public static event Action<bool> TaskWasCompleted;

    public void Complete(bool isComplete)
    {
        TaskWasCompleted?.Invoke(isComplete);
    }
}
