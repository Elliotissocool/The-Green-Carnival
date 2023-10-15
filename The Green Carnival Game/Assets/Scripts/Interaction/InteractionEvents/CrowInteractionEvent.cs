using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class CrowInteractEvent
{
    public static event Action OnCrowInteract;

    public static void TriggerCrowInteract()
    {
        OnCrowInteract?.Invoke();
    }
}

