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

        // render and apply color
        GetComponent<Renderer>().material.color = colorActual;
        r = GetComponent<Renderer>();
        r.material.color = colorActual;

        // perform transform and apply size
        t = GetComponent<Transform>();
        t.localScale = Vector3.one * tamano;
        transform.localScale = Vector3.one * tamano;

        // If the cube is called "Cube_A", and it has not moved, then its position changes
        if (gameObject.name == "Cube_A" && !moved)
        {
            // here you can enter a random number.
            transform.position = new Vector3(transform.position.x - 3f,
                                            transform.position.y,
                                            transform.position.z);
            moved = true;
        }

    }
}