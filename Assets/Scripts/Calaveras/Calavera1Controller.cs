using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera1Controller : MonoBehaviour
{
    public GameObject imagenPrueba1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba1.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba1.SetActive(false);
        }
    }
}
