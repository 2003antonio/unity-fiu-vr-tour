using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{
    // List of tour sites
    public GameObject[] objSites;
    // Main menu canvas
    public GameObject canvasMainMenu;
    // Camera movement toggle
    public bool isCameraMove = false;

    private CameraController cameraController;

    void Start()
    {
        cameraController = GetComponent<CameraController>();
        if (cameraController == null)
        {
            Debug.LogError("CameraController component is missing on this GameObject.");
        }
    }

    void Update()
    {
        if (isCameraMove && Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMenu();
        }
    }

    public void LoadSite(int siteNumber)
    {
        if (siteNumber >= 0 && siteNumber < objSites.Length)
        {
            // Deactivate all sites first
            foreach (GameObject site in objSites)
            {
                site.SetActive(false);
            }

            // Activate the selected site
            objSites[siteNumber].SetActive(true);
            canvasMainMenu.SetActive(false);
            isCameraMove = true;

            cameraController?.ResetCamera();
        }
        else
        {
            Debug.LogError("Invalid site number selected.");
        }
    }

    public void ReturnToMenu()
    {
        // Reactivate the main menu
        canvasMainMenu.SetActive(true);

        // Deactivate all sites
        foreach (GameObject site in objSites)
        {
            site.SetActive(false);
        }

        // Disable camera movement
        isCameraMove = false;
    }
}