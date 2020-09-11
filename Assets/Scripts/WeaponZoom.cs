using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    Camera playerCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    // Start is called before the first frame update

    bool zoomedInToggle = false;

    void Start()
    {
        playerCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
         playerCamera.fieldOfView = zoomedInFOV;
        }
        else
        {
            playerCamera.fieldOfView = zoomedOutFOV;
        }
    }
}
