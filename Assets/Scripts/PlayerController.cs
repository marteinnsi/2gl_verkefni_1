using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [NonSerialized] public bool Alive = true;
    private GameController _gameController;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _gameController = FindObjectOfType<GameController>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Alive)
        {
            if (transform.position.y < -1)
            {
                Kill(restartDelay: 2);
                return;
            }

            _gameController.Score = (int) (_rigidbody.transform.position.z / 5.0f);
            _rigidbody.AddForce(Input.GetAxisRaw("Horizontal"), 0, 0, ForceMode.Impulse);
            _rigidbody.AddForce(0, 0, 15f, ForceMode.Acceleration);
        }
    }

    public void Kill(bool restart = true, int restartDelay = 5)
    {
        if (Alive)
        {
            Alive = false;
            if (restart)
            {
                _gameController.Invoke(nameof(GameController.RestartLevel), restartDelay);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (Alive)
        {
            if (other.collider.CompareTag("Obstacle"))
            {
                Kill();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Kill(false);
            _gameController.Invoke(nameof(GameController.NextLevel), 5);
        }
    }
}