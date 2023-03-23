using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public float previusTime;
    float fallTime = 0.8f;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-100, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(100, 0, 0);
        }
        if (Time.time - previusTime > (Input.GetKeyDown(KeyCode.DownArrow) ? fallTime * 10 : fallTime))
        {
            transform.position += new Vector3(0, -100, 0);
            previusTime = Time.time;
        }
    }
}
