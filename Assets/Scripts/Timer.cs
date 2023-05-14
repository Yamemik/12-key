using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float time=60f;
    [SerializeField]
    Text text;
    void Start()
    {
        text.text = time.ToString();
    }

    void Update()
    {
        time -= Time.deltaTime;
        text.text = Mathf.Round(time).ToString();
        text.text = text.text;
        if (time <= 0.0f)
        {
            SceneManager.LoadScene(3);
        }
    }
}
