using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_GameController : MonoBehaviour {
    private bool targetInScope;
    public void TargetLost() {
        targetInScope = false;
        StartCoroutine(Funcion());
    }

    public void TargetFound() {
        targetInScope = true;
        StopCoroutine(Funcion());
    }

    IEnumerator Funcion() {
        yield return new WaitForSeconds(3);
        if (targetInScope == false) {
            //SceneManager.LoadScene("PlantaPrincipal", LoadSceneMode.Single);
            var lastSceneIndex = SceneManager.sceneCount;
            SceneManager.UnloadSceneAsync(lastSceneIndex);
        }
    }

    public void DetectarCalavera() {
        if (!PlayerPrefs.HasKey("password")) PlayerPrefs.SetString("password", "");
        var valorActual = PlayerPrefs.GetString("password");
        PlayerPrefs.SetString("password", valorActual + "C");
    }

    public void DetectarCandelabro()
    {
        if (!PlayerPrefs.HasKey("password")) PlayerPrefs.SetString("password", "");
        var valorActual = PlayerPrefs.GetString("password");
        PlayerPrefs.SetString("password", valorActual + "X");
    }

    public void DetectarPlanta()
    {
        if (!PlayerPrefs.HasKey("password")) PlayerPrefs.SetString("password", "");
        var valorActual = PlayerPrefs.GetString("password");
        PlayerPrefs.SetString("password", valorActual + "P");
    }
}
