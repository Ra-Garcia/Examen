using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
//using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class NewBehaviourScript : DefaultObserverEventHandler
{
    public Image Image;
    [Space]
    public Color colorFound;
    public Color colorLost;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log("<color=green><b>FOUND</b></color>");
        Image.color = colorFound;
    }

    protected override void OnTrackingLost()
    {
       base.OnTrackingLost();
        Debug.Log("<color=red><b>LOST</b></color>");
        Image.color = colorLost;
    }
}