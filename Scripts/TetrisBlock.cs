using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public Vector3 rotationPoint;
    public float previusTime;
    float fallTime = 0.8f;
    public static int height = 20;
    public static int width = 10;
    public Color[] colors = {
        Color.blue,
        Color.red,
        Color.yellow,
        Color.green,
        Color.magenta,
    };
    private void Start() {
        MenjajBoju();
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
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
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
