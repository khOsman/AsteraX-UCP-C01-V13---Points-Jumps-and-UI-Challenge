using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    [SerializeField]
	private Text _scoreText;
    [SerializeField]
	private Text _jumpText;

    public void SetScoreUIFromUIController(int score)
    {
        _scoreText.text = score.ToString();
    }

    public void SetJumpUIFromUIController(int jumps)
    {
        _jumpText.text = "Jumps : "+jumps.ToString();
    }

}
