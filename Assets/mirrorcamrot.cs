using UnityEngine;

public class MirrorCamRot : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        if (cameraTransform != null)
        {
            Vector3 directionToCamera = cameraTransform.position - transform.position;
            directionToCamera.y = 0;
            transform.rotation = Quaternion.LookRotation(directionToCamera);
        }
    }
}