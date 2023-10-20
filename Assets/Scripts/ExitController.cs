using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    public GameObject exit;
    // Start is called before the first frame update
    public void click()
    {
        Debug.Log("hola");
        var lastSceneIndex = SceneManager.sceneCount;
        SceneManager.UnloadSceneAsync(lastSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
