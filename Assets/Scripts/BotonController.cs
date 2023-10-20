using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonController : MonoBehaviour {
    public GameObject teclado;
    public GameObject text;
    public GameObject barras1;
    // Start is called before the first frame update
    public void click() {
        var teclado1 = teclado.GetComponent<InputField>();
        var text1 = text.GetComponent<Text>();
        if (teclado1.text.Equals("2552")) {
            barras1.SetActive(false);
            text1.text = "Código Correcto!";
        } else {
            text1.text = "Código Incorrecto!";
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
