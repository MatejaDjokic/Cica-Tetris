using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
    public GameObject[] tetramini;
    void Start()
    {
        NoviTetramin();
    }

    public void NoviTetramin()
    {
        Instantiate(tetramini[Random.Range(0, tetramini.Length)], transform.position, Quaternion.identity);
    }
}
