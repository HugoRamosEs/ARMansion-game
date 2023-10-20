using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera3Controller : MonoBehaviour
{
    public GameObject imagenPrueba3;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba3.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba3.SetActive(false);
        }
    }
}
