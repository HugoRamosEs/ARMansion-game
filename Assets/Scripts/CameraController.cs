using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Personaje;
    private Vector3 Posicion;

    // Start is called before the first frame update
    void Start()
    {
        Posicion = transform.position - Personaje.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Personaje.transform.position + Posicion;
    }
}
