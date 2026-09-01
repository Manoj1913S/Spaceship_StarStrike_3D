using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] timelinesTextDialogue;
   [SerializeField] TMP_Text dialogueLines;

   //Integers to track  index of currently which text line play
   int currentLines = 0;


  public  void NextDialogueLines()
    {
        currentLines = currentLines+1; //increase dialog index  line  by line
        //choose which timeline text to display on a dialog text 
        dialogueLines.text = timelinesTextDialogue[currentLines];

    }
}
