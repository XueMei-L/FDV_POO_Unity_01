using UnityEngine;

public class CuboDeColores : MonoBehaviour
{
    // PROPIEDADES
    public Color colorActual = Color.blue;  // Color del cubo
    public float tamano = 1f;               // Tamaño del cubo

    bool moved = false; // 记录是否已经移动过

    private Rigidbody rb;                    // Referencia al Rigidbody
    private Renderer r;                      // Referencia al Renderer
    private Transform t;

    void Start()
    {

    }
    void Update()
    {
        // get rigidbody
        rb = GetComponent<Rigidbody>();

        // render y aplicar color
        GetComponent<Renderer>().material.color = colorActual;
        r = GetComponent<Renderer>();
        r.material.color = colorActual;

        // realizar transform y aplicar tamaño
        t = GetComponent<Transform>();
        t.localScale = Vector3.one * tamano;
        transform.localScale = Vector3.one * tamano;

        // Ejemplo: si el cubo se llama "CuboMovimiento", cambia su posición
        if (gameObject.name == "Cube_A" && !moved)
        {
            transform.position = new Vector3(transform.position.x - 3f,
                                            transform.position.y,
                                            transform.position.z);
            moved = true;
        }

    }
}