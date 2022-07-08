using UnityEngine;
public class Bouncing : MonoBehaviour
{
    [SerializeField] private float _force = 8f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerOnStep(other);
    }

    private void PlayerOnStep(Collision2D col)
    {
        if (col.relativeVelocity.y < 0)
        {
            Player.Instance.rb.velocity = Vector2.up * _force;
        }
    }
}
