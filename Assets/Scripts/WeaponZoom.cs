using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutMouseSensitivity = 2f;
    [SerializeField] float zoomInMouseSensitivity = 0.5f;

    bool zoomedInToogle = false;

    void OnDisable()
    {
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToogle)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    void ZoomIn()
    {
        zoomedInToogle = true;
        fpsCamera.fieldOfView = zoomInFOV;
        fpsController.mouseLook.XSensitivity = zoomInMouseSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInMouseSensitivity;
    }

    void ZoomOut()
    {
        zoomedInToogle = false;
        fpsCamera.fieldOfView = zoomOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutMouseSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutMouseSensitivity;
    }
}
