using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayershipMovement : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] float xControlSpeed = 10f; //left right speed
    [SerializeField] float yControlSpeed = 10f; //top down speed

    [Header("Scrren Clamp/Boundary")]
    [SerializeField] float xClampedRange = 5f; //left right screen clamp
    [SerializeField] float yClampedRange = 5f; //to down screen clamp

    [Header("Ship Rotation")]
    [SerializeField] float zAxisRotation = 20f; //NOTE: when we pressed a A/D then rocket move left right and also it rotete 20f in z axis which feel tilt effect(Dhalkinu)

     [Header("SmoothMovement in UpDownLeftRight")]
    [SerializeField] float rotationLRSmoothSpeed = 10f; //LR =Left/Right
    [SerializeField] float controlUpDownPitch = 15f;

    Vector2 movementValue;//It gives -1 and +1 only (-x and -y similarly +x and +y)

    void Update()
    {
        SpaceshipMoveLogic();
        SpaceshipRotationLogic();
    }


    public void OnMove(InputValue value) //PlayerControls named input action ma Move named action create gareko 
    {
        movementValue = value.Get<Vector2>();
        Debug.Log(movementValue);
    }

     void SpaceshipMoveLogic()
    {
        float xOffsetValue = movementValue.x * xControlSpeed * Time.deltaTime; //INFO: for left right move so direction*Speed*Time(movementValue.x = diection,xcontrolspeed = speed,Time.deltatime = time)
        float xPosValue = transform.localPosition.x + xOffsetValue; //INFO: transform.localPosition.x =  rocket Current X Position, xOffsetValue = current frame ma kati X direction januparne ho,xPosValue = rocket sarepachhi wa move garepachhi ko New X Position baki same y ma pani tala gareko chha 
        float xClampedPos = Mathf.Clamp(xPosValue, -xClampedRange, xClampedRange); //x position ma clamp garne


        float yOffsetValue = movementValue.y * yControlSpeed * Time.deltaTime; //for Up Down Move
        float yPosValue = transform.localPosition.y + yOffsetValue;
        float yClampedPos = Mathf.Clamp(yPosValue, -yClampedRange, yClampedRange);

        transform.localPosition = new Vector3(
            xClampedPos, yClampedPos,
            transform.localPosition.z
        );
    }

    //Spaceship tilt logic 
    void SpaceshipRotationLogic()
    {
        float smoothLeftRightMove = -zAxisRotation*movementValue.x; //NOTE: game ma A press garda movemantValue.x =-1 then -zaxisRotation = -20 = +20 game ko scene ma z+ huda chai left rotate hune axis chha tesaile zAxisRotation - banayeko similarly z axis - huda chai rocket right tilt hunchha so yo kura yesari code through achieve gareko so yesto kura ke garda kata rotate kata translate chai simply game scene herera idea generate garne then tehi anusar code apply garne 
        float smoothUpDownMove = -controlUpDownPitch*movementValue.y;  //NOTE:same as x

        Quaternion targetRotation = Quaternion.Euler(smoothUpDownMove,0f,smoothLeftRightMove); //NOTE: when i press D it has +1 then -zAxisRotation provide so +1 * -20  = -20 in total so rocket right move and -20 rotate in z axix  
        transform.localRotation = Quaternion.Lerp(transform.localRotation,targetRotation,rotationLRSmoothSpeed*Time.deltaTime);//Rocket lai currentrotation(transform.localrotation bata targetRotation samma bistarai rotationSpeed =10f le laijau yekaipatak nalaga and  target rotation ma aayeko value rocket ko localRotation ma dinchha jasle garda tilt hunchha yedi yo nagarne ho bhane only tilt  value dincha targetRotation le but no tilt
              
    }

   
}
