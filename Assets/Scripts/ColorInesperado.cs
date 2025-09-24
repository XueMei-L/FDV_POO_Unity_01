using UnityEngine;
public class ColorInesperado : MonoBehaviour
{
    private Renderer rend;
    public Color colorEsperado;
    void Start()
    {
        rend = GetComponent<Renderer>();
        // Asignamos un valor incorrecto a la variable
        colorEsperado = Color.red;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Intentamos cambiar el color del material al valor de la variable
            rend.material.color = colorEsperado;
            // debugging
            Debug.Log("El color que se asignará es: " + colorEsperado);
        }
    }
}
