using UnityEngine;
using System.Collections.Generic;

public class Zadanko : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2,3,1,3,2  };
    List<int> jedynki = new List<int>();
    List<int> trojki = new List<int>();
    List<int> dwojki = new List<int>();


    void Start()
    {
        foreach (int liczba in dane)
        {
            if (liczba == 1)
            {
                jedynki.Add(liczba);
                Debug.Log("jedynki: " + jedynki.Count);
            }
            else if (liczba == 2)
            {
                dwojki.Add(liczba);
                Debug.Log("dwojki: " + dwojki.Count);   
            }
            else if (liczba == 3)
            {
                trojki.Add(liczba);
                Debug.Log("trojki: " + trojki.Count);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
