using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    public GameObject explosionPrefab;
    private PointManager pointManager;

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(coll.gameObject);
        Destroy(gameObject);
        pointManager.UpdateScore(10);
    }
}