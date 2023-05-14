using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boxes : MonoBehaviour
{
    [SerializeField] private Sprite boxOpen;

    float speed;
    public Image img;

    void Start()
    {
        //transform.localPosition = new Vector2(transform.localPosition.x)
        speed = Random.Range(5, 9);
    }
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (transform.localPosition.x <= -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") Destroy(gameObject);
    }
}
