using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class AcelerometerController : MonoBehaviour {
    public bool SensorEnabled = false;
    public bool HasSensor = false;
    public Text DebugText;
    public GameObject Arrow;

    void Start() {
        HasSensor = Accelerometer.current != null;
        if (HasSensor) InputSystem.EnableDevice(Accelerometer.current);
        else Debug.Log("Accelerometer sensor isnt detected");
    }

    void Update() {
        if (SensorEnabled && HasSensor) {
            var acceleration = Accelerometer.current.acceleration.ReadValue();
            Arrow.transform.Rotate(0, 0, -acceleration.x);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            SensorEnabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            SensorEnabled = false;
        }
    }
}
