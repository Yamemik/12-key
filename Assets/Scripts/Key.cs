using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{

    public Text text;
    
    int score;
    private float startX;
    private bool isFlying;


    void Start()
    {
        startX = transform.position.x;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    void Update()
    {
        text.text = score.ToString();

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            isFlying = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
        if (isFlying)
        {
            transform.Translate(Time.deltaTime * 13, 0, 0);
        }
        else
        {
            transform.position = new Vector3(startX, Mathf.Sin(Time.timeSinceLevelLoad * 3) * 4f);
        }
        if (transform.position.x > 10)
        {
            isFlying = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box0")
        {
            isFlying = false;
            GetComponent<BoxCollider2D>().enabled = false;
            score++;
        }
    }
}
