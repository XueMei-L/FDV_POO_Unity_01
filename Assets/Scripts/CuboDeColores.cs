using UnityEngine;

public class CuboDeColores : MonoBehaviour
{
    // PROPIEDADES
    public Color colorActual = Color.blue;  // Color del cubo
    public float tamano = 1f;                // Tamaño del cubo

    private Rigidbody rb;                    // Referencia al Rigidbody
    private Renderer r;                      // Referencia al Renderer
    private Transform t;

    void Start()
    {
        // get rigidbody
        rb = GetComponent<Rigidbody>();

        // render y aplicar color
        r = GetComponent<Renderer>();
        r.material.color = colorActual;

        // realizar transform y aplicar tamaño
        t = GetComponent<Transform>();
        t.localScale = Vector3.one * tamano;
    }
    void Update()
    {
        
    }
}