using UnityEngine;

public class CrackStep : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Collider2D _coll;
    private Animator _animator;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _coll = GetComponent<Collider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerOnStep(other);
    }

    public void Init()
    {
        _rb.bodyType = RigidbodyType2D.Static;
        _coll.enabled = true;
    }
    public void PlayerOnStep(Collision2D col)
    {
        if (col.relativeVelocity.y < 0)
        {
            _coll.enabled = false;

            _rb.bodyType = RigidbodyType2D.Dynamic;
            _animator.Play("CrackState");
        }
    }
}
