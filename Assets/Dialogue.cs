using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] dialogueLines;
    private int currentLine = 0;

    void Start()
    {
        ShowLine();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextLine();
        }
    }

    void ShowLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
    }

    void NextLine()
    {
        currentLine++;
        if (currentLine < dialogueLines.Length)
        {
            ShowLine();
        }
        else
        {
            dialogueText.text = "";
        }
    }
}
