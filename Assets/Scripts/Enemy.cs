using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float Speed = -2.5f;
    float Barrier = -4.5f;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector3.up);
        if (transform.position.y <= Barrier)
        {
            gameManager.GameOver();
        }
    }
}
