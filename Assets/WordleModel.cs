using UnityEngine;


// MODDEL SCRIPT HOLDS DATA; DOES NOT RETURN GAMEPLAY LOGIC OR RUN CALCULATIONS (MVC FORMAT)
public class WordleModel : MonoBehaviour
{
    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;

    public string correctAnswer;
    public int currentAttempt;
    public void Setup()
    {
        // Create arrays of words
        string[] possibleAnswers = possibleAnswersAsset.ToString().Split('\n');
        string[] allowedWords = allowedWordsAsset.ToString().Split('\n');

        // Choose random word to be answer
        correctAnswer = possibleAnswers[Random.Range(0, possibleAnswers.Length)];
        correctAnswer = correctAnswer.ToLower().Trim();

        /* FOR TESTING
        correctAnswer = possibleAnswers[0];
        */
    }




    public bool isValidGuess(string guess)
    {
        return true;
    }
}