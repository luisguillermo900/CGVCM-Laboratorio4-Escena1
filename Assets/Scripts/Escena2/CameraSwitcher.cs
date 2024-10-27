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
        // Inicia con la c�mara en tercera persona activa
        ActivateCamera(thirdPersonCamera);
    }

    void Update()
    {
        // Cambia a la c�mara en primera persona
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateCamera(firstPersonCamera);
        }
        // Cambia a la c�mara en tercera persona
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateCamera(thirdPersonCamera);
        }
        // Cambia a la c�mara est�tica
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateCamera(staticCamera);
        }
        // Cambia a la c�mara de vista lateral
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivateCamera(sideViewCamera);
        }
    }

    // M�todo para activar la c�mara seleccionada y desactivar las dem�s
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
