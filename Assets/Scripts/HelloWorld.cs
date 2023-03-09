using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void OnDisable() {
        Debug.Log("Goodbye World!");
    }
    void OnEnable() {
        Debug.Log("Hello World!");
    }
}
