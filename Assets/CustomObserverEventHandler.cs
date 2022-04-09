using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
        VuforiaApplication.Instance.OnVuforiaPaused += OnPaused;
    }
     private void OnVuforiaStarted()
    {
    VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
        FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    VuforiaBehaviour.Instance.CameraDevice.SetCameraMode(Vuforia.CameraMode.MODE_DEFAULT);
    }

    private void OnPaused(bool paused)
    {
        if (!paused) // Resumed
        {
        // Set again autofocus mode when app is resumed
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
            FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }

 protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        //Debug.Log(" FOUND! ");
        //Debug.Log($"< color = green > "+ " FOUND! " + "</ b ></ color >");
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        //Debug.Log(" LOST! ");
        //Debug.Log($"< color = red >< b > LOST </ b ></ color >");
    }

   
}
