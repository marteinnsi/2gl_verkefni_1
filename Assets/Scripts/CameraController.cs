using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController _player;
    private Vector3 _offset = new Vector3(0, 1.75f, -5f);

    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (_player.Alive)
        {
            transform.position = _player.transform.position + _offset;
        }
    }
}