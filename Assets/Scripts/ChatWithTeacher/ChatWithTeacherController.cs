using System;
using UnityEngine;

public class ChatWithTeacherController : MonoBehaviour
{
    public static event Action<bool> TaskWasCompleted;

    public void Complete(bool isComplete)
    {
        TaskWasCompleted?.Invoke(isComplete);
    }
}
