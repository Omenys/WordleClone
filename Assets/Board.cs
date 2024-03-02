using UnityEngine;

public class Board : MonoBehaviour
{
    private KeyCode[] Supported_Keys = new KeyCode[] {
    KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D,
    KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H,
    KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L,
    KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P,
    KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T,
    KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X,
    KeyCode.Y, KeyCode.Z, };

    public Row[] rows;
    public int rowIndex;
    public int columnIndex;
    [SerializeField] WordleModel model;
    [SerializeField] WordleController controller;


    private void Awake()
    {
        rows = GetComponentsInChildren<Row>();
    }

    // Update is called once per frame
    void Update()
    {
        Row currentRow = rows[rowIndex];

        // If backspace, set tile at row and column index to null character
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            columnIndex--;
            // Make sure backspacing does not go outside of array range
            if (columnIndex < 0)
            {
                columnIndex = 0;
            }
            Row row = rows[rowIndex];
            Tile tile = row.tiles[columnIndex];
            tile.SetLetter('\0');

        }
        // Submit guess
        else if (columnIndex >= currentRow.tiles.Length - 1 && Input.GetKeyDown(KeyCode.Return))
        {
            // Submit guess  at current row
            controller.SubmitGuess(currentRow);

            // If end of board reached, no longer accept input
            if (rowIndex >= rows.Length)
            {
                enabled = false;
                Debug.Log("Attempt to access out of row boundaries");
                return;
            }

        }
        else if (columnIndex <= currentRow.tiles.Length - 1)
        {
            for (int i = 0; i < Supported_Keys.Length; i++)
            {
                // If supported key is pressed, update tile at row and column index to character
                if (Input.GetKeyDown(Supported_Keys[i]))
                {
                    Row row = rows[rowIndex];
                    if (row == null)
                    {
                        Debug.Log("Attempt to access outside of row boundaries");
                        return;
                    }
                    Tile tile = row.tiles[columnIndex];
                    if (tile == null)
                    {
                        Debug.Log("Attempt to access outside of tile boundaries");
                        return;
                    }
                    tile.SetLetter((char)Supported_Keys[i]);
                    columnIndex++;
                    break;
                }
            }
        }
    }

}
