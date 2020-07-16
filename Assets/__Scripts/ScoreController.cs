using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	//Need the UIController reference
	[SerializeField]
	private UIController _uIController;

	private int _score = 0;


    //getter & setter method for _score
	public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            SetScore();
        }
    }

    private void Awake()
    {
         SetScore();
       
    }


   
    public void SetScore()
    {
       
        _uIController.SetScoreUIFromUIController(_score);
        //PlayerPref : Stores and accesses player preferences between game sessions.
        //Using SetType("ReferenceKey",value)  Types: Int Float String
         PlayerPrefs.SetInt("Score", _score);

    }

}
