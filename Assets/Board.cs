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

    private Row[] rows;
    private int rowIndex;
    private int columnIndex;


    private void Awake()
    {
        rows = GetComponentsInChildren<Row>();
    }

    // Update is called once per frame
    void Update()
    {
        if (columnIndex >= rows[rowIndex].tiles.Length)
        {

        }
        else
        {
            for (int i = 0; i < Supported_Keys.Length; i++)
            {
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
