using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Player _player;

    public static CameraController Instance;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Update()
    {
        if (_player.transform.position.y > this.transform.position.y)
        {
            this.transform.position = new Vector3(0, _player.transform.position.y, -10);
        }
    }
}

