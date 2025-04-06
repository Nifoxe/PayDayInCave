using UnityEngine;

public class mirrorcamrot : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        //if (cameraTransform != null)
        //{
        //    Vector3 directionToCamera = cameraTransform.position - transform.position;
        //    directionToCamera.y = 0;
        //    Quaternion lookRotation = Quaternion.LookRotation(directionToCamera);
        //    Quaternion mirroredRotation = Quaternion.Euler(lookRotation.x * -1, lookRotation.y * -1, lookRotation.z * -1);
        //    transform.rotation = mirroredRotation;
        //}
    }
}
