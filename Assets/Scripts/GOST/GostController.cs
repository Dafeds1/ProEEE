using System;
using UnityEngine;

public class GostController : MonoBehaviour
{
    public static event Action<bool> TestWasPassed;
    
    public void Passed(bool value)
    {
        TestWasPassed?.Invoke(value);
    }
}
