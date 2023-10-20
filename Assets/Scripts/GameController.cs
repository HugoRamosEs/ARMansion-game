using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public List<GameObject> velas;
    public GameObject player;
    public GameObject barras3;
    int velascontadas = 0;

    void Update() {
        MicLoudness = MicrophoneLevelMax();
        //MicLoudnessinDecibels = MicrophoneLevelMaxDecibels();
        //Debug.Log("MicLoudness: " + MicLoudness);
        //Debug.Log("MicLoudnessinDecibels: " + MicLoudnessinDecibels);

        if (MicLoudness == 1) {
            foreach (GameObject vela in velas) {
                var posicion = player.transform.position - vela.transform.position;
                var animator = vela.GetComponent<Animator>();
                if (posicion.magnitude <= 0.4172759f && animator.GetFloat("velaEncendida") == 0) {
                    animator.SetFloat("velaEncendida", 1);
                    velascontadas = velascontadas + 1;
                }
                if (velascontadas == 5) {
                    Debug.Log("Todas las velas contadas");
                    barras3.SetActive(false);

                }
                //Debug.Log(posicion.magnitude + "/" + MicLoudness + "/" + MicLoudnessinDecibels);
            }
        }
        //Debug.Log("Velascontadas: " + velascontadas);
    }

    #region Micro
    public static GameController Inctance { set; get; }
    public static float MicLoudness;
    public static float MicLoudnessinDecibels;
    private string _device;
    private AudioClip _clipRecord;
    private AudioClip _recordedClip;
    private int _sampleWindow = 128;
    bool _isInitialized;

    //mic initialization
    public void InitMic() {
        // levelMax equals to the highest normalized value power 2, a small number because < 1
        // pass the value to a static var so we can access it from anywhere
        //Debug.Log("InitMicro");
        if (_device == null) {
            _device = Microphone.devices[0];
        }
        _clipRecord = Microphone.Start(_device, true, 999, 44100);
        _isInitialized = true;
    }

    public void StopMicrophone() {
        //Debug.Log("StopMicro");
        Microphone.End(_device);
        _isInitialized = false;
    }

    //get data from microphone into audioclip
    float MicrophoneLevelMax() {
        float levelMax = 0;
        float[] waveData = new float[_sampleWindow];
        int micPosition = Microphone.GetPosition(null) - (_sampleWindow + 1); // null means the first microphone
        if (micPosition < 0) return 0;
        _clipRecord.GetData(waveData, micPosition);
        // Getting a peak on the last 128 samples
        for (int i = 0; i < _sampleWindow; i++) {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak) {
                levelMax = wavePeak;
            }
        }
        return levelMax;
    }

    //get data from microphone into audioclip
    float MicrophoneLevelMaxDecibels() {
        float db = 20 * Mathf.Log10(Mathf.Abs(MicLoudness));
        return db;
    }

    public float FloatLinearOfClip(AudioClip clip) {
        StopMicrophone();

        _recordedClip = clip;

        float levelMax = 0;
        float[] waveData = new float[_recordedClip.samples];

        _recordedClip.GetData(waveData, 0);
        // Getting a peak on the last 128 samples
        for (int i = 0; i < _recordedClip.samples; i++) {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak) {
                levelMax = wavePeak;
            }
        }
        return levelMax;
    }

    public float DecibelsOfClip(AudioClip clip) {
        StopMicrophone();

        _recordedClip = clip;

        float levelMax = 0;
        float[] waveData = new float[_recordedClip.samples];

        _recordedClip.GetData(waveData, 0);
        // Getting a peak on the last 128 samples
        for (int i = 0; i < _recordedClip.samples; i++) {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak) {
                levelMax = wavePeak;
            }
        }

        float db = 20 * Mathf.Log10(Mathf.Abs(levelMax));

        return db;
    }

    // start mic when scene starts
    void OnEnable() {
        InitMic();
        _isInitialized = true;
        Inctance = this;
    }

    //stop mic when loading a new level or quit application
    void OnDisable() {
        StopMicrophone();
    }

    void OnDestroy() {
        StopMicrophone();
    }


    // make sure the mic gets started & stopped when application gets focused
    void OnApplicationFocus(bool focus) {
        if (focus) {
            //Debug.Log("Focus");
            if (!_isInitialized) {
                //Debug.Log("Init Mic");
                InitMic();
            }
        }
        if (!focus) {
            //Debug.Log("Pause");
            StopMicrophone();
            //Debug.Log("Stop Mic");

        }
    }

    #endregion
}
