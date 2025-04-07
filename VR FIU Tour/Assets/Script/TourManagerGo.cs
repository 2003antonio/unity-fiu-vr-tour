using System.Collections;
using UnityEngine;
using UnityEngine.UI; // For Toggle

public class TourManagerGo : MonoBehaviour
{
    [Header("Tour Configuration")]
    public Transform[] cameraLocations;      // Set these in the Inspector
    public GameObject OVRCameraRig;          // Drag your OVRCameraRig prefab here

    private int currentIndex = 0;

    // Called by the Toggle
    public void HandleToggle(bool isOn)
    {
        if (isOn)
        {
            GoToNextLocation();
            StartCoroutine(ResetToggle());
        }
    }

    private void GoToNextLocation()
    {
        currentIndex++;

        if (currentIndex >= cameraLocations.Length)
        {
            Debug.Log("Reached end of tour."); 
            return;
        }

        MoveCameraToLocation(currentIndex);
    }

    private void MoveCameraToLocation(int index)
    {
        if (index >= 0 && index < cameraLocations.Length)
        {
            OVRCameraRig.transform.position = cameraLocations[index].position;
            OVRCameraRig.transform.rotation = cameraLocations[index].rotation;
        }
    }

    private IEnumerator ResetToggle()
    {
        // Wait a frame so Unity finishes the Toggle event
        yield return new WaitForEndOfFrame();

        // Reset the Toggle state so user can click it again
        Toggle toggle = GetComponent<Toggle>();
        if (toggle != null)
        {
            toggle.isOn = false;
        }
    }
}
