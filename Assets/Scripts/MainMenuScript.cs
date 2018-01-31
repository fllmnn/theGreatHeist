﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public Text highscore;
    public Text actualScore;

    private void Start()
    {
        //loads the highscore
        highscore.text = PlayerPrefs.GetFloat("Highscore",0.00f).ToString() + " $";
        actualScore.text = "Score: " +  PlayerPrefs.GetFloat("Score", 0.00f).ToString() + " $";
    }

    //Function to reset highscore
    public void ResetHighScore() {

        PlayerPrefs.SetFloat("Highscore", 0.00f);
        highscore.text = PlayerPrefs.GetFloat("Highscore", 0.00f).ToString();
    }

    //Starts the game by loading the game scene
    public void StartGame() {
        SceneManager.LoadSceneAsync("Storage01", LoadSceneMode.Single);
    }

    //Returns to main menu.
    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    }
}
