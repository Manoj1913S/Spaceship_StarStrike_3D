using UnityEngine;

public class EnemyHitByPlayer : MonoBehaviour
{
    [SerializeField] GameObject enemyDestoryParticles; //To store particle system prefab it made
    [SerializeField] float healthPoints = 3f;
    [SerializeField] int  scoreValue = 10;
  
    //NOTE: malai enemy lai playership le destroy garda bittikai score increase hune banaunu chha so tesko lagi Score increase hune logic Scoreboard.cs ma yeuta method chha public void IncreaseScore name ko so teslai access garna yo gareko yeslai direct SerializeField bata refrence nailinu ko reason hai Instantiate means doesnot hasve scene view it appeare in runtime so yo way follow
    Scoreboard showScore;

    void Start()
    {
        showScore = FindAnyObjectByType<Scoreboard>(); //only one scoreboard in scene then we use it 
    }
    void OnParticleCollision(GameObject other)
    {
        EnemyHealthLogic();
         Debug.Log("LASER HIT: " + other.name); //for debugging
    }

    private void EnemyHealthLogic()
    {
        healthPoints = healthPoints - 1; //healthPoints--

        if (healthPoints <= 0)
        {
           showScore.IncreaseScore(scoreValue);
            Instantiate(enemyDestoryParticles, transform.position, Quaternion.identity); //particleprefabname,particleinstantiate hune position(transform.position=jun enemy hit gareko and destroy bhayeko position ma hunchha), rotationno need so auatarnion.identity)
            Destroy(gameObject); //NOTE: It means destroy game object which is attached this script 

        }
    }
}
