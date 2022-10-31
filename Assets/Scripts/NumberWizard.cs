using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TO be able to Serialize a text field with Text Mesh Pro, you need to use this Class

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start() 
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (min >= max) return;
        min = guess + 1;
        NextGuess();
    } 

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString(); // The ToString() Method will convert a value to a String
    }
}