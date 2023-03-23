using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public Vector3 rotacionaTacka;
    public float prosloVreme;
    public float prosloDesnoVreme;
    public float prosloLevoVreme;
    float desnoVrema = 0.1f;
    float levoVreme = 0.1f;
    float vremePadanja = 0.8f;
    static int visina = 20;
    static int sirina = 10;
    public static Transform[,] mrezaPolja = new Transform[sirina, visina];
 Color[] colors = {
        Color.blue,
        Color.red,
        Color.yellow,
        Color.green,
        Color.magenta,
    };
    private void Start()
    {
        MenjajBoju();
    }
    void Update()
    {
        if (Time.time - prosloLevoVreme > levoVreme && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!ValidanKorakTetrisBloka())
                transform.position += new Vector3(1, 0, 0);
            prosloLevoVreme = Time.time;
        }
        else if (Time.time - prosloDesnoVreme > desnoVrema && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!ValidanKorakTetrisBloka())
                transform.position += new Vector3(-1, 0, 0);
            prosloDesnoVreme = Time.time;
        }
        else if (Time.time - prosloVreme > (Input.GetKey(KeyCode.DownArrow) ? vremePadanja / 10 : vremePadanja))
        {
            transform.position += new Vector3(0, -1, 0);
            if (!ValidanKorakTetrisBloka())
            {
                transform.position += new Vector3(0, 1, 0);
                DodajUMrezuPolja();
                this.enabled = false;
                FindAnyObjectByType<TetraminoSpawner>().NoviTetramin();
            }
            prosloVreme = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(rotacionaTacka), new Vector3(0, 0, 1), 90);
            if (!ValidanKorakTetrisBloka())
                transform.RotateAround(transform.TransformPoint(rotacionaTacka), new Vector3(0, 0, 1), -90);
        }
    }
    void CheckForLine()
    {
        for (var i = visina - 1; i >= 0; i--)
        {
            if (HasLine(i))
            {
                DeleteLine(i);
                RowDown(i);
            }
        }
    }
    bool HasLine(int i)
    {
        for (var j = 0; j < sirina; j++)
        {
            if (mrezaPolja[i, j])
            {
                return false;
            }
        }
        return true;
    }
    void DeleteLine(int i)
    {
        for (var j = 0; j < sirina; j++)
        {
            Destroy(mrezaPolja[i, j].gameObject);
            mrezaPolja[i, j] = null;
        }
    }
    void RowDown(int i)
    {
        for (var j = 0; j < visina; j++)
        {
            for (var k = 0; k < sirina; k++)
            {
                if (mrezaPolja[j, k] != null)
                {
                    mrezaPolja[j, k - 1] = mrezaPolja[j, k];
                    mrezaPolja[j, k] = null;
                    mrezaPolja[j, k - 1].transform.position -= new Vector3(0, 1, 0);
                }
            }
        }
    }
    void MenjajBoju()
    {
        int randomIndex = Random.Range(0, colors.Length);
        foreach (Transform children in transform)
        {
            children.GetComponent<SpriteRenderer>().color = colors[randomIndex];
        }
    }

    void DodajUMrezuPolja()
    {
        foreach (Transform children in transform)
        {
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
            int roundedX = Mathf.RoundToInt(children.transform.position.x);

            mrezaPolja[roundedX, roundedY] = children;
        }
    }
    bool ValidanKorakTetrisBloka()
    {
        foreach (Transform children in transform)
        {
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
            int roundedX = Mathf.RoundToInt(children.transform.position.x);

            if (roundedX < 0 || roundedX >= sirina || roundedY <= 0 || roundedY >= visina)
            {
                return false;
            }
            if (mrezaPolja[roundedX, roundedY] != null)
            {
                return false;
            }
        }
        return true;
    }
}
