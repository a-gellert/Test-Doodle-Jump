using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Rigidbody2D rb;
    public float YDistance { get; private set; } = 0;
    public bool IsOver { get; private set; } = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Instance == null)
        {
            Instance = this;
        }
        rb.bodyType = RigidbodyType2D.Static;
    }
    public void StartGame()
    {

        IsOver = false;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
    public void RestartGame()
    {
        YDistance = 0;
        transform.position = new Vector3(0, 1, 0);
        StartGame();
    }
    public void PauseGame()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }

    void Update()
    {
        if (transform.position.x > 2.3f)
        {
            transform.position = new Vector3(-2.3f, transform.position.y, 1);
        }
        if (transform.position.x < -2.3f)
        {
            transform.position = new Vector3(2.3f, transform.position.y, 1);
        }
        if (YDistance < transform.position.y)
        {
            YDistance = transform.position.y;
        }
        if (YDistance - transform.position.y > 6)
        {
            Debug.Log(22);
            Player.Instance.PauseGame();
            PauseMenuTweening.Instance.OnPause();
            IsOver = true;
        }
    }

    public void OnLeft()
    {
        rb.velocity = new Vector2(-1.5f, rb.velocity.y);
    }
    public void OnRight()
    {
        rb.velocity = new Vector2(1.5f, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Jetpack")
        {
            other.GetComponent<Jetpack>().Jet();
        }
    }
}
