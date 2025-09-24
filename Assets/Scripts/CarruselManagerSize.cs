using UnityEngine;

public class CarruselManagerSize : MonoBehaviour
{
    public GameObject[] cubes;

    public void ChangeSize()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Debug.Log($"Cube {i+1} cambiado a tamaño {0.5f}");
        }
    }
}
