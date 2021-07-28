using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinHandler : MonoBehaviour
{
    public UnityEvent WonEvent;

    public void Won()
    {
        WonEvent.Invoke();
    }
}
