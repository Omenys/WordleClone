using UnityEngine;


// MODDEL SCRIPT HOLDS DATA; DOES NOT RETURN GAMEPLAY LOGIC OR RUN CALCULATIONS (MVC FORMAT)
public class WordleModel : MonoBehaviour
{
    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;

    string correctAnswer;
    int currentAttempt;
    public void Setup()
    {
        // Create arrays of words
        string[] possibleAnswers = possibleAnswersAsset.ToString().Split('\n');
        string[] allowedWords = allowedWordsAsset.ToString().Split('\n');

        foreach (string answer in possibleAnswers)
        {
            Debug.Log(answer);
        }
    }

    // Choose random word to be answer



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
