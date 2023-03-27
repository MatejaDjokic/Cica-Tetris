using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizivacTetramina : MonoBehaviour
{
    public GameObject[] tetramini;
    public GameObject roditelj;
    void Start()
    {
        NoviTetramin();
    }

    public void NoviTetramin()
    {
        Instantiate(tetramini[Random.Range(0, tetramini.Length)], transform.position, Quaternion.identity, roditelj.transform);
    }
}
