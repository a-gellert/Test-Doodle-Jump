using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Player _player;

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.y > this.transform.position.y)
        {
            this.transform.position = new Vector3(0, _player.transform.position.y, -10);
        }
    }
}

