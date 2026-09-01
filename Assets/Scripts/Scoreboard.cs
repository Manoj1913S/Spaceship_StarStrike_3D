using UnityEngine;
using TMPro;

//INFO: This Scripts Handle When our playership destroy the enemy spaceship then increase the score 
public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreBoardText; //UI Canvas ma create gareko ScoreText game object lai yeha drag and drop gari line
    int score = 0;
   

   public  void IncreaseScore(int amount) //amount  is used  to increase score
    {
        score = score+amount;
        scoreBoardText.text =  score.ToString();  //Grad and drip gareko 00000 named gameobject ma bhayeko text increase garne logic 
    }
}
