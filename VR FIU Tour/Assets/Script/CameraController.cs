using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Mouse sensitivity
    public float rotateSpeed = 300.0f;
    public float zoomSpeed = 5.0f;
    private float zoomAmount = 0.0f;
    private float targetZoom = 0.0f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera is missing in the scene.");
        }
    }

    void Update()
    {
        HandleRotation();
        HandleZoom();
    }

    void HandleRotation()
    {
        if (Input.GetMouseButton(0))
        {
            float rotationX = -Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            transform.localEulerAngles += new Vector3(rotationX, rotationY, 0);
        }
    }

    void HandleZoom()
    {
        if (Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            targetZoom = Mathf.Clamp(targetZoom + Input.GetAxis("Mouse Y") * zoomSpeed, -5.0f, 5.0f);
        }

        zoomAmount = Mathf.Lerp(zoomAmount, targetZoom, Time.deltaTime * zoomSpeed);

        if (mainCamera != null)
        {
            mainCamera.transform.localPosition = new Vector3(0, 0, zoomAmount);
        }
    }

    public void ResetCamera()
    {
        transform.localEulerAngles = Vector3.zero;
        targetZoom = 0.0f;
        zoomAmount = 0.0f;

        if (mainCamera != null)
        {
            mainCamera.transform.localPosition = new Vector3(0, 0, zoomAmount);
        }
    }
}

