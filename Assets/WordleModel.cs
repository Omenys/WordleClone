using System.Collections.Generic;
using UnityEngine;

public class WordleModel : MonoBehaviour
{

    int currentAttempt;
    TextAsset possibleAnswersAsset;
    TextAsset allowedWordsAsset;
    List<string> possibleAnswers = new List<string>();
    List<string> allowedWords = new List<string>();
    string correctAnswer;

    void Setup()
    {

    }

    bool isValidGuess(string guess)
    {
        return true;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
