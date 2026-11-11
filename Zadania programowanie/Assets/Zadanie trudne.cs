using UnityEngine;

public class Zadanietrudne : MonoBehaviour
{

    public GameObject[] objects = new GameObject[5];
    public Gradient colorGradient;
    public float YpositionSpeed = 5f;



    void Start()
    {


    }

    void Update()
    {
        CheckObjects();
    }
    //FUNKCJA 1
    // Sprawdza czy obiekt jest 2D czy 3D

    void CheckObjects()
        {
            for (int i =0; i < objects.Length; i++)
            {
                if (objects[i].GetComponent<SpriteRenderer>() != null)
                {
                Debug2D(objects[i].GetComponent<SpriteRenderer>());
                }
                else if (objects[i].GetComponent<MeshRenderer>() != null)
                {
                Debug3D(objects[i].transform);
                }
            }
        }

    // FUNKCJA 2
    // Przyjmuje SpriteRenderer
    void Debug2D(SpriteRenderer spriteRenderer)
    {
        float CurrentY = spriteRenderer.transform.position.y;
        float normalizedY = Mathf.InverseLerp(0f, 10f, CurrentY);
        Color newColor = colorGradient.Evaluate(normalizedY);
        spriteRenderer.color = newColor;


    }

    // FUNKCJA 3
    // Przyjmuje Transform
    void Debug3D(Transform transformCube)
    {

        float CurrentY = transformCube.transform.position.y;
        transformCube.rotation = Quaternion.Euler(0f, 0f, CurrentY * 5f);
        transformCube.position += Vector3.up * YpositionSpeed * Time.deltaTime;
    }


    
}

