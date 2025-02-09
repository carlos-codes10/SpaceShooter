using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float LSpeed = 5.0f;
    private GameManager gameManager;
    int LaserDeath = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void Kill()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D()
    {
        Kill();
        gameManager.ScoreAdder();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(LSpeed * Time.deltaTime * Vector3.up);

        if(transform.position.y > LaserDeath)
        {
            Kill();
        }
           
    }
}
