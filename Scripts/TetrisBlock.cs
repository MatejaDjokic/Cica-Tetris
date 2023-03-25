using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
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
    public static string rec = "Radovanj";

    Color[] colors = {
=======
=======
>>>>>>> parent of c581f1a (coommit)
    public Vector3 rotationPoint;
    public float previusTime;
    float fallTime = 0.8f;
    public static int height = 20;
    public static int width = 10;
    public Color[] colors = {
<<<<<<< HEAD
>>>>>>> parent of c581f1a (coommit)
=======
>>>>>>> parent of c581f1a (coommit)
        Color.blue,
        Color.red,
        Color.yellow,
        Color.green,
        Color.magenta,
    };
    private void Start() {
        MenjajBoju();
        ZadajSlovoTetraminu(rec);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!ValidanKorakTetrisBloka())
                transform.position += new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!ValidanKorakTetrisBloka())
                transform.position += new Vector3(-1, 0, 0);
        }
        else if (Time.time - previusTime > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {
            transform.position += new Vector3(0, -1, 0);
            if (!ValidanKorakTetrisBloka())
                transform.position += new Vector3(0, 1, 0);
            previusTime = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
            if (!ValidanKorakTetrisBloka())
<<<<<<< HEAD
<<<<<<< HEAD
                transform.RotateAround(transform.TransformPoint(rotacionaTacka), new Vector3(0, 0, 1), -90);
        }
    }
    void ZadajSlovoTetraminu(string str){
        rec = str;
        char slovo = rec[Random.Range(0,rec.Length)];
        foreach(Transform dete in transform){
            
        }
    }
    void ProveriLiniju()
    {
        for (var i = visina - 1; i >= 0; i--)
        {
            if (ImaLiniju(i))
            {
                IzbrisiLiniju(i);
                RedDole(i);
            }
        }
    }
    bool ImaLiniju(int i)
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
    void IzbrisiLiniju(int i)
    {
        for (var j = 0; j < sirina; j++)
        {
            Destroy(mrezaPolja[i, j].gameObject);
            mrezaPolja[i, j] = null;
        }
    }
    void RedDole(int i)
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
=======
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
>>>>>>> parent of c581f1a (coommit)
=======
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
>>>>>>> parent of c581f1a (coommit)
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

    bool ValidanKorakTetrisBloka()
    {
        foreach (Transform children in transform)
        {
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
            int roundedX = Mathf.RoundToInt(children.transform.position.x);

            if (roundedX < 0 || roundedX >= width || roundedY <= 0 || roundedY >= height)
            {
                return false;
            }
        }
        return true;
    }
}
