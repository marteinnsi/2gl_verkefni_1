using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private Text _text;
    private GameController _gameController;
    
    void Start()
    {
        _text = GetComponent<Text>();
        _gameController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        _text.text = _gameController.Score.ToString("0");
    }
}
