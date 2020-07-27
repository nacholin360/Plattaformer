using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public GameObject Character_0;
    private Vector3 posicionRelativa;
    public Vector3 Distancia;

    // Use this for initialization
    void Start()
    {

        posicionRelativa = transform.position - Character_0.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 Position = Character_0.transform.position + posicionRelativa + Distancia;
        transform.position = Position;

    }
}
