using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    Camera playerCamera;
    RigidbodyFirstPersonController playerController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 1.5f;
    [SerializeField] float zoomedInSensitivity = 0.5f;
    // Start is called before the first frame update

    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    void Start()
    {
        playerCamera = FindObjectOfType<Camera>();
        playerController = GetComponentInParent<RigidbodyFirstPersonController>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            ZoomIn();
        }
        else
        {
            ZoomOut();
        }
    }

    private void ZoomOut()
    {
        playerCamera.fieldOfView = zoomedOutFOV;
        playerController.mouseLook.XSensitivity = zoomedOutSensitivity;
        playerController.mouseLook.YSensitivity = zoomedOutSensitivity;
    }

    private void ZoomIn()
    {
        playerCamera.fieldOfView = zoomedInFOV;
        playerController.mouseLook.XSensitivity = zoomedInSensitivity;
        playerController.mouseLook.YSensitivity = zoomedInSensitivity;
    }
}
