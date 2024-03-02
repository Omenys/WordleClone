using UnityEngine;


// CONTROLLER SCRIPT INTERACTS WITH MODEL & PROCESSES GAME DATA, CALCULATIONS, ETC (MVC FORMAT)
public class WordleController : MonoBehaviour
{
    [SerializeField] WordleModel model;
    //[SerializeField] WordleView view;


    public void SubmitGuess(Row row)
    {

    }

    public void WinGame()
    {

    }

    public void LoseGame()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        model.Setup();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
