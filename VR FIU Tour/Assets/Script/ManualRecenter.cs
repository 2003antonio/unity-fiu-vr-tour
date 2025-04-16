using UnityEngine;

public class ManualRecenter : MonoBehaviour
{
    private float holdTime = 0f;
    private float requiredHoldDuration = 2.5f; // seconds

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            holdTime += Time.deltaTime;

            if (holdTime >= requiredHoldDuration)
            {
                OVRManager.display.RecenterPose();
                Debug.Log("Recenter triggered after holding");
                holdTime = 0f; // Reset so it doesn't retrigger
            }
        }
        else
        {
            holdTime = 0f; // Reset if user lets go
        }
    }
}
