using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpController : MonoBehaviour {

    //Need the UIController reference
    [SerializeField]
    private UIController _uIController;

    private int _jumps = 3;


    //getter & setter method for _jumps
    public int Jumps
    {
        get { return _jumps; }
        set
        {
            _jumps = value;
            //Checking Is player losing all jumps or not
            if(_jumps <= 0)
            {
                //If player lost alol his jumps 
                _jumps = 0;
                //then player dies & GameOver Scene will pop up for 1 second
                Invoke("PlayerDie", 1);
            }
            //Updating jumps status
            SetJumps();

        }
    }

    private void Awake()
    {
        SetJumps();
    }

    public void SetJumps()
    {
        _uIController.SetJumpUIFromUIController(_jumps);
    }

    private void PlayerDie()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex)
        //Upper code refers the current scene and buildIndex can carry the 
        //current scenes index number.
        //It will call the next Scene which is our gameplay scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
