using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;
public class LightController : MonoBehaviour {
    //public bool SensorEnabled = false;
    //public bool HasSensor = false;
    public GameObject imagen;
    public Text DebugText;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            //SensorEnabled = true;
            imagen.SetActive(true);
            
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            //SensorEnabled = false;
            imagen.SetActive(false);
        }
    }

    #region IntentoLuz
    // Start is called before the first frame update
    //void Start() {
    //HasSensor = Accelerometer.current != null;
    //if (HasSensor) InputSystem.EnableDevice(LightSensor.current);
    //else {
    //Debug.Log("Light sensor isnt detected");
    //DebugText.text = "Light sensor isnt detected";
    //}
    //}
    // Update is called once per frame
    //void Update() {
    //if (SensorEnabled) {
    //try
    //{
    //AxisControl temp = LightSensor.current.lightLevel;
    //Debug.Log("LightSensor: " + temp);
    //DebugText.text = $"{temp.clamp} {temp.scaleFactor} {temp.normalizeZero} {temp.normalizeMax} {temp.normalizeMin} {temp.scale} {temp.invert} {temp.clampConstant} {temp.clampMax} {temp.clampMin} {temp.normalize}";
    //}
    //catch (System.Exception ex)
    //{
    //DebugText.text = ex.Message;
    //}
    //}
    //}
    #endregion
}
