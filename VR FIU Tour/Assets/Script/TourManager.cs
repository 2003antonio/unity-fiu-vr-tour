using UnityEngine;

public class TourManager : MonoBehaviour
{
    public GameObject[] objSites; // List of 360° sites (spheres)
    public GameObject canvasMainMenu; // VR Menu
    public bool isCameraMove = false; // Is the user in a scene?

    void Start()
    {
        // Ensure menu is visible initially
        if (canvasMainMenu != null)
            canvasMainMenu.SetActive(true);
    }

    void Update()
    {
        //code for returning to menu
        if (isCameraMove)
        {
            if (isCameraMove)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    ReturnToMenu();
                }
            }
        }
    }

    public void LoadSite(int siteNumber)
    {
        if (objSites == null || objSites.Length == 0)
        {
            Debug.LogWarning("No sites are assigned in objSites array!");
            return;
        }

        if (siteNumber < 0 || siteNumber >= objSites.Length)
        {
            Debug.LogWarning("Invalid site index: " + siteNumber);
            return;
        }

        // Hide all sites first
        foreach (GameObject site in objSites)
        {
            site.SetActive(false);
        }

        // Show the selected site
        objSites[siteNumber].SetActive(true);

        // Hide the menu if it exists
        if (canvasMainMenu != null)
            canvasMainMenu.SetActive(false);

        // Enable camera movement
        isCameraMove = true;
    }

    public void ReturnToMenu()
    {
        // Show menu
        if (canvasMainMenu != null)
            canvasMainMenu.SetActive(true);

        // Hide all sites
        foreach (GameObject site in objSites)
        {
            site.SetActive(false);
        }

        // Disable camera movement
        isCameraMove = false;
    }

    // === Wrapper Methods for UI Buttons ===
    public void LoadSite0() { LoadSite(0); }
    public void LoadSite1() { LoadSite(1); }
    public void LoadSite2() { LoadSite(2); }
    public void LoadSite3() { LoadSite(3); }
    public void LoadSite4() { LoadSite(4); }
    public void LoadSite5() { LoadSite(5); } // Add more if needed
}

