using UnityEngine;

public class ShronkAndDestroy : MonoBehaviour
{
    public float shrinkTime = 1f;

    void Update()
    {
        transform.localScale -= Vector3.one * (Time.deltaTime /  shrinkTime);
        if (transform.localScale.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
