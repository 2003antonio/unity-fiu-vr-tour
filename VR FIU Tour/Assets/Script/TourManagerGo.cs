using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TourManagerGo : MonoBehaviour
{
    [Header("Tour Configuration")]
    public Transform[] cameraLocations;
    public GameObject OVRCameraRig;

    [Header("Scene Management")]
    public string nextSceneName;

    private int currentIndex = 0;

    // Move to the next location in the tour
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
            currentIndex = 0;
        }

        MoveCameraToLocation(currentIndex);
    }

    public void GoToFirstLocation()
    {
        currentIndex = 0;
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
        yield return new WaitForEndOfFrame();
        Toggle toggle = GetComponent<Toggle>();
        if (toggle != null)
        {
            toggle.isOn = false;
        }
    }

    // Load the next Unity scene
    public void LoadNextSite()
    {
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
