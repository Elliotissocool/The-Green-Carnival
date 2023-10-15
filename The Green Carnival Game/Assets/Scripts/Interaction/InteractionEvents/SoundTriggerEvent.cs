using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class SoundTriggerEvent
{
    public static event Action<GameObject> OnSoundTrigger;

    public static void TriggerSoundTrigger(GameObject triggeredObject)
    {
        OnSoundTrigger?.Invoke(triggeredObject);
    }
}

