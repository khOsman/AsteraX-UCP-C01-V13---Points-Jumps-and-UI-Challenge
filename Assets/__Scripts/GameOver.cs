using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private Text _scoreTxt;

	private void Start()
    {
        SetLatestScoreUI();
        //After 2.5 seconds GamePlay scene will come back
        StartCoroutine(Reload());
    }



	private void SetLatestScoreUI()
    {
        //Using Gettype("ReferenceKey)  we are getting the stored score value from ScoreController
        _scoreTxt.text = PlayerPrefs.GetInt("Score").ToString();
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(2.5f);
        ReloadGame();
    }

    private void ReloadGame()
    {
        //It will call the previos Scene which is our gameplay scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
