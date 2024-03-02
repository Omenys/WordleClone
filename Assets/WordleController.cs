using UnityEngine;


// CONTROLLER SCRIPT INTERACTS WITH MODEL & PROCESSES GAME DATA, CALCULATIONS, ETC (MVC FORMAT)
public class WordleController : MonoBehaviour
{
    [SerializeField] WordleModel model;
    //[SerializeField] WordleView view;
    [SerializeField] Board board;


    public void WinGame()
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
    public void SubmitGuess(Row row)
    {
        // Iterate through each tile and check against the accepted/possible word lists
        for (int i = 0; i < row.tiles.Length; i++)
        {
            // Tile currently on
            Tile tile = row.tiles[i];

            if (tile.letter == model.correctAnswer[i])
            {
                // Correct Answer
            }
            else if (model.correctAnswer.Contains(tile.letter))
            {
                // Letter within word but wrong position
            }
            else
            {
                // Incorrect
            }
        }

        // Go to next row
        board.rowIndex++;

        // Reset column position
        board.columnIndex = 0;

    }
}
