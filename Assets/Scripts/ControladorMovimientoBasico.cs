using System.Security.Cryptography;
using UnityEngine;

public class ControladorMovimientoBasico : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad configurable desde el Inspector

    void Update()
    {
        // forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        // back
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        // left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        // right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
