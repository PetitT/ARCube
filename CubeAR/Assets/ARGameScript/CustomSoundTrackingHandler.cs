using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSoundTrackingHandler : DefaultTrackableEventHandler
{
    public AudioSource audio;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        audio.Play();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        audio.Pause();
    }
}
