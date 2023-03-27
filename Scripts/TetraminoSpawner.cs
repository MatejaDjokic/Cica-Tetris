using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
    public GameObject[] tetramini;
    GameObject prosliTetramin;
    GameObject roditelj;

    void Start()
    {
        NoviTetramin();
    }

    void NoviTetramin()
    {
        GameObject tetraminPrefab = tetramini[Random.Range(0, tetramini.Length)];
        while (tetraminPrefab = prosliTetramin)
        {
            tetraminPrefab = tetramini[Random.Range(0, tetramini.Length)];
        }
        prosliTetramin = tetraminPrefab;
        GameObject noviTetramin = Instantiate(tetraminPrefab, transform.position, Quaternion.identity, roditelj.transform);

    }
}
