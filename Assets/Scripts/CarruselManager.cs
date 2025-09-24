using UnityEngine;

public class CarruselManager : MonoBehaviour
{
    // Instantiate objects of other classes.
    private CarruselManagerColor colorManager;
    private CarruselManagerSize sizeManager;

    void Start()
    {
        // look for the components
        colorManager = GetComponent<CarruselManagerColor>();
        sizeManager = GetComponent<CarruselManagerSize>();

        // loaded the cubes in both classes
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        colorManager.cubes = cubes;
        sizeManager.cubes = cubes;

        Debug.Log("Total cubes found: " + cubes.Length);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You have pressed space on the keyboard");
            colorManager.ChangeColor();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("You have pressed k on the keyboard");
            sizeManager.ChangeSize();
        }
    }
}
