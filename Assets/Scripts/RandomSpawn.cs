using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private float spawnRate = 2f;

    float RandY;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;
    void Update()
    {
        if (Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            RandY = Random.Range(-4.2f, 4.35f);
            whereToSpawn = new Vector2(transform.position.x, RandY);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
