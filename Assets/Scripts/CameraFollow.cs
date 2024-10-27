using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public LayerMask collisionLayers;
    public float minDistance = 1.0f;
    public float maxDistance = 4.0f;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        RaycastHit hit;

        // Detección de colisiones con un rayo
        if (Physics.Raycast(player.position, offset.normalized, out hit, maxDistance, collisionLayers))
        {
            transform.position = player.position + offset.normalized * (hit.distance - minDistance);
        }
        else
        {
            transform.position = desiredPosition;
        }
    }
}