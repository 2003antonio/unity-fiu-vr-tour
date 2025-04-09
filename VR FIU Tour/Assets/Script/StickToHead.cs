using UnityEngine;

public class StickToHead : MonoBehaviour
{
    public Transform head;

    void LateUpdate()
    {
        if (head != null)
        {
            transform.position = head.position + head.forward * 0.5f;
            transform.rotation = Quaternion.LookRotation(head.forward);
        }
    }
}
