using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(0, 0.1f, 0);
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 1f);
        Destroy(coll.gameObject);
        Destroy(gameObject);

    }
}
