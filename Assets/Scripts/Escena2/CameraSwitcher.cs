using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    public Camera staticCamera;
    public Camera sideViewCamera;

    private Camera activeCamera;

    void Start()
    {
        // Inicia con la cámara en tercera persona activa
        ActivateCamera(thirdPersonCamera);
    }

    void Update()
    {
        // Cambia a la cámara en primera persona
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateCamera(firstPersonCamera);
        }
        // Cambia a la cámara en tercera persona
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateCamera(thirdPersonCamera);
        }
        // Cambia a la cámara estática
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateCamera(staticCamera);
        }
        // Cambia a la cámara de vista lateral
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivateCamera(sideViewCamera);
        }
    }

    // Método para activar la cámara seleccionada y desactivar las demás
    void ActivateCamera(Camera cameraToActivate)
    {
        firstPersonCamera.gameObject.SetActive(false);
        thirdPersonCamera.gameObject.SetActive(false);
        staticCamera.gameObject.SetActive(false);
        sideViewCamera.gameObject.SetActive(false);

        cameraToActivate.gameObject.SetActive(true);
        activeCamera = cameraToActivate;
    }
}
