using UnityEngine;

public class VRCameraController : MonoBehaviour
{
    public Transform cameraTransform; // Reference to the VR camera (CenterEyeAnchor)
    public TourManager tourManager; // Reference to the TourManager
    public float rotationSpeed = 2.0f; // Manual rotation speed
    public float zoomSpeed = 0.2f; // Zoom speed
    public float minZoom = 0.5f; // Minimum zoom level
    public float maxZoom = 2.0f; // Maximum zoom level
    private float currentZoom = 1.0f; // Default zoom level

    void Start()
    {
        // Get the TourManager component in the scene
        tourManager = FindObjectOfType<TourManager>();

        // Assign the CenterEyeAnchor if not set
        if (cameraTransform == null)
        {
            GameObject centerEyeAnchor = GameObject.Find("CenterEyeAnchor");
            if (centerEyeAnchor != null)
            {
                cameraTransform = centerEyeAnchor.transform;
            }
            else
            {
                Debug.LogError("CenterEyeAnchor not found! Make sure it exists in the scene.");
            }
        }
    }

    void Update()
    {
        if (tourManager == null || cameraTransform == null) return;

        if (tourManager.isCameraMove)
        {
            // Use the headset's natural rotation
            Quaternion headsetRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
            cameraTransform.rotation = headsetRotation;

            // Manual rotation using the right thumbstick
            float horizontal = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
            float vertical = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;

            if (Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
            {
                Vector3 rotation = new Vector3(-vertical, horizontal, 0) * rotationSpeed;
                cameraTransform.Rotate(rotation * Time.deltaTime);
            }

            // Zooming with left thumbstick (Y-axis)
            float zoomInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;

            // Zooming with grip triggers
            float leftGrip = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
            float rightGrip = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            float gripZoom = rightGrip - leftGrip; // Zoom in with right, out with left

            // Apply zoom
            currentZoom += (zoomInput + gripZoom) * zoomSpeed * Time.deltaTime;
            currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

            // Adjust camera's local scale for zoom effect
            cameraTransform.localScale = Vector3.one * currentZoom;
        }
    }
}


