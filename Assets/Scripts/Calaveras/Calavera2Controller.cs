using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera2Controller : MonoBehaviour
{
    public GameObject imagenPrueba2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba2.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba2.SetActive(false);
        }
    }
}
