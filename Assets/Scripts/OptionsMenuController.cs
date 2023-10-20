using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenuController : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    public void SetVolume (float volume)
    {
        Debug.Log("Volumen: " + volume);
        audioMixer.SetFloat("Volumen", volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
