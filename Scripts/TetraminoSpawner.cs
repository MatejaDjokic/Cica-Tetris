using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
public GameObject[] tetraminos;
    void Update()
    {
        NewTetramino();
    }

    void NewTetramino(){
        Instantiate(tetraminos[Random.Range(0,tetraminos.Length)],transform.position,Quaternion.identity);
    }
}
