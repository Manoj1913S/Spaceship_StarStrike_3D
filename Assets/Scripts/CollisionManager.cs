using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] GameObject playerDestroyParticle;

     ReloadGameScene restartGameScene; //script reference varaible

    void Start()
    {
        restartGameScene = FindFirstObjectByType<ReloadGameScene>(); //take a script reference by using findfirst object by type another way is take a SerializedField method
    }




    void OnTriggerEnter(Collider other)
    {
        //when playership collide with other like enemy ship then player ship got destroy and play above particle called playerDestroyParticles
     Instantiate(playerDestroyParticle, transform.position,Quaternion.identity);
     Destroy(this.gameObject); //INFO:kun gameobject ma yo script destroy chha tyo gameobject destroy gar bhaneko ho in this case yo script playership ma attached chha so destroy playership when playership collide with other colliders

     restartGameScene.RestartLevel(); //when a player ship has collide with other gameobject then reload and restart again current game level
     
     
    }
}
