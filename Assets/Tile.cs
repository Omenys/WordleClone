using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    private TextMeshProUGUI text;
    public char letter { get; private set; }
    public Color defaultColor = Color.gray;
    public Color correctColor = Color.green;
    public Color almostColor = Color.yellow;
    public Color incorrectColor = Color.gray;
    public Image tileImage;

    public enum TileState
    {
        Default, Correct, Almost, Incorrect
    }

    public void SetTileState(TileState state)
    {
        switch (state)
        {
            case TileState.Correct:
                tileImage.color = correctColor;
                break;
            case TileState.Almost:
                tileImage.color = almostColor;
                break;
            case TileState.Incorrect:
                tileImage.color = incorrectColor;
                break;
            default:
                tileImage.color = defaultColor;
                break;
        }

    }

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        tileImage = GetComponent<Image>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString();
    }

}
