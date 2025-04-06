using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject menu;
    public GameObject Inv;
    public GameObject Loans;

    public float configsens;
    private float sens;
    public Transform orientation;
    float xRotation;
    float yRotation;

    void Update()
    {
        if (!menu.activeSelf && !Inv.activeSelf && !Loans.activeSelf)
        {
            sens = configsens * 25;
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sens;
            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}
