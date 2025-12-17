using UnityEngine;

public class playerHealth : MonoBehaviour
{
    private bool isDead;
    GameManagerScript gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

    void Update()
    {
        if (transform.position.y < -5.5f && !isDead)
        {
            isDead = true;
            gm.gameOver();
        }
    }
}
