using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameText : MonoBehaviour
{
    // Start is called before the first frame update
        int min = 1;
        int max = 1000;
        int shoot = 500;

    void Start()
    {
        Debug.Log("Witaj w grze! Wymysl liczbe od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od"+shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od"+shoot + " ?");
        }
       
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe!");
        }
    }
}
