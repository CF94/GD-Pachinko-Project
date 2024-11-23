using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform Target; //Player
    [SerializeField]
    private Transform cameraTransform;
    [SerializeField]
    private Vector2 Offset;
    [SerializeField]
    private float smoothTime;

    private Vector2 velocity = Vector2.zero;

    private void LateUpdate()
    {
        // Convert the target position to Vector2 and apply the offset
        Vector2 targetPosition = (Vector2)Target.position + Offset;

        // SmoothDamp works with Vector2, but we need to convert the camera position to Vector2 as well
        Vector2 smoothPosition = Vector2.SmoothDamp((Vector2)cameraTransform.position, targetPosition, ref velocity, smoothTime);

        // Set the camera's position (converting the smoothed Vector2 back to Vector3)
        cameraTransform.position = new Vector3(smoothPosition.x, smoothPosition.y, cameraTransform.position.z);

        // Make the camera look at the target
        cameraTransform.LookAt(Target);
    }
}
