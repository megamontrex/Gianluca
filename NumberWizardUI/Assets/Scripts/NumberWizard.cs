using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour
{

    //creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;
    int MaxNmberofTries = 10;

    public Text guessText;

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (Random.Range(min,max));


        guessText.text = guess.ToString();

        MaxNmberofTries--;
        if (MaxNmberofTries == 0)//if Ai doesnt guess the number you win
        {
            SceneManager.LoadScene("Win");
        }
    }

    void Start()
    {

    }

}
        	
	
	