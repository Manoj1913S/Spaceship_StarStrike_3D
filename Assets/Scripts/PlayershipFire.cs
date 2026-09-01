using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayershipFire : MonoBehaviour
{

    //INFO: out logic has when player pressed left mouse button then fire bullet particle so achieve this first off all goes particle system(laser particle) then look emission and activate this beacuse emission off it disappear similarly emission on particle system play so achieve this 
    [SerializeField] GameObject[] lasersParticlesGameobject; //Whole ParticleSystem gameObject lai yeha drag and drop garne yeha 2 wota laser accesss garnu parne chha so chutta chuttai 2 banaunu ko satta Array[] use gariyo then yes game object ko emission lai get garnu talako code chha 
                                                             // ParticleSystem.EmissionModule emissionModule; //Particle system ma bhayeko Emission bhanne component lai yeha liyera aayo
    [SerializeField] RectTransform crossHairGameObject;

    //SphereTargetPoint lo gameobject ko Transform lai  reference line so 
    [SerializeField] Transform sphereTargetingPoint;

    //Spherepoint chai kaha samma jane tyo distcanc dinuparyo ni ta so 
    [SerializeField] float targetSpherePointDistance = 100f;


    bool isFiring = false; //at first it has false 

    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        FiringLogic();
        CrosshairFollowMousePosition();
        MoveTargetSphereLogic();
        AimLasersBullet();
    }
    void OnLaserfiring(InputValue value) //when a player press left moause button then it call new input system so left mousebutton press then activete this logic we implement in input action  so code checked pressed or not if press then if goto next function called update/start in this case update called so inside update has FiringLOgic() so update refer to FiringLogic() and run every frame when player press left mouse 
    {
        isFiring = value.isPressed;
    }
    void FiringLogic()
    {
        //foreeach loop ko through all laser fire gareko yekaipatak
        foreach (GameObject laserParticle in lasersParticlesGameobject)
        {
            //start ma get component gareko bhaye particle ko length patta lagayera tyo length lai for loop ko through access gari balla fire garnupartheo tyo kurabata bachnu yo use gareko var wala internal delceration technique
            var emissionModule = laserParticle.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }

    }

    void CrosshairFollowMousePosition()
    {
        crossHairGameObject.position = Mouse.current.position.ReadValue();
    }

    void MoveTargetSphereLogic()
    {
        Vector3 targetSpherePointPosition = new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), targetSpherePointDistance);
        sphereTargetingPoint.position = Camera.main.ScreenToWorldPoint(targetSpherePointPosition);//ball follow the cursor yo code ko logic  nai yehi ho
    }

    void AimLasersBullet()
    {
        foreach (GameObject laserParticle in lasersParticlesGameobject)
        {
            Vector3 fireDirection = sphereTargetingPoint.position - this.transform.position;//INFO: we are substracting the laser position from the target position so it return vector between the laser and taret point(laser ra enemy ko target distance calculate garchha )
            Quaternion rotationLaserTarget = Quaternion.LookRotation(fireDirection); //INFO: Quaternion.LookRotation() provide rotation of laser that will align it to the vector 
            laserParticle.transform.rotation = rotationLaserTarget; //INFO: in this  line number three, we can move the lasers.transform.rotation 
        }
    }
}
