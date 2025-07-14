using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform personaje;
    public Vector3 offset; // Puedes ajustar esto para modificar la distancia entre el personaje y la cámara

    void Update()
    {
        if (personaje != null)
        {
            transform.position = personaje.position + offset;
        }
    }
}