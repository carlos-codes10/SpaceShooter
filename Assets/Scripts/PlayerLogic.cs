using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] float Speed = 12.0f;
    int Seconds;
    private GameManager gameManager;
    [SerializeField] GameObject laserPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }



    public void Kill()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D()
    {
        Kill();
        gameManager.GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = (Input.GetAxis("Horizontal"));
        transform.Translate(horizontalInput * Speed * Time.deltaTime * Vector3.right);
        Vector3 offset = new Vector3(0, 1.3f, 0);

        if (Input.GetButtonDown("Jump"))
        {
           Instantiate(laserPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
