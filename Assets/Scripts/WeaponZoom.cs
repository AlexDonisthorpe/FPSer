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

    void Start()
    {
        playerCamera = FindObjectOfType<Camera>();
        playerController = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            playerCamera.fieldOfView = zoomedInFOV;
            playerController.mouseLook.XSensitivity = zoomedInSensitivity;
            playerController.mouseLook.YSensitivity = zoomedInSensitivity;
        }
        else
        {
            playerCamera.fieldOfView = zoomedOutFOV;
            playerController.mouseLook.XSensitivity = zoomedOutSensitivity;
            playerController.mouseLook.YSensitivity = zoomedOutSensitivity;
        }
    }
}
