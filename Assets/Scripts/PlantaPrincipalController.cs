using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaPrincipalController : MonoBehaviour {
    private bool barras2 = false;
    public GameObject barras2objecto;
    public GameObject textoInicio;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        //Debug.Log("ProgramBegins");
        PlayerPrefs.SetFloat("PlayerX", 16);
        PlayerPrefs.SetFloat("PlayerY", -5);

    }
    public void Start()
    {
        StartCoroutine(Funcion());
    }
    IEnumerator Funcion()
    {
        textoInicio.SetActive(true);
        yield return new WaitForSeconds(5);
        textoInicio.SetActive(false);
    }

    private void Update() {
        if (!barras2) {
            if (!PlayerPrefs.HasKey("password")) PlayerPrefs.SetString("password", "");
            var valorActual = PlayerPrefs.GetString("password");
            if (valorActual.Contains("CPX")) {
                barras2 = true;
                barras2objecto.SetActive(false);
            }
        }
    }
}
