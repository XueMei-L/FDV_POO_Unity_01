using UnityEngine;

public class CarruselManagerColor : MonoBehaviour
{
    public GameObject[] cubes;
    public Color[] colors = { Color.red, Color.yellow, Color.blue, Color.green, Color.gray };
    // Execise 6.1
    // void Start()
    // {
    //     Debug.Log("Empieza el juego");
    //     //asign the all cubes to the list
    //     cubes = GameObject.FindGameObjectsWithTag("Cube");
    //     Debug.Log("Total cubes found: " + cubes.Length);
    // }
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         ChangeColor();
    //     }
    // }

    // void ChangeColor()
    // {
    //     for (int i = 0; i < cubes.Length; i++)
    //     {
    //         Renderer r = cubes[i].GetComponent<Renderer>();
    //         if (r != null)
    //         {
    //             Debug.Log("Se ha cambiado el color de" + "Cube" + (i + 1));
    //             // Asignar un color del array usando índice modular
    //             r.material.color = colors[i % colors.Length];
    //             Debug.Log($"Cube {i + 1} cambiado a {r.material.color}");
    //         }
    //     }
    // }

    public void ChangeColor()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            Renderer r = cubes[i].GetComponent<Renderer>();
            if (r != null)
            {
                Debug.Log("Se ha cambiado el color de" + "Cube" + (i + 1));
                // Asignar un color del array usando índice modular
                r.material.color = colors[i % colors.Length];
                Debug.Log($"Cube {i + 1} cambiado a {r.material.color}");
            }
        }
    }
}
