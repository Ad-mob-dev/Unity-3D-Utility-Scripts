using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;        //Public variable to store a reference to the player game object
    Vector3 offset;            //Private variable to store the offset distance between the player and camera
    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {

        float rotateY = player.transform.eulerAngles.y;
        //using SmoothDampAngle Function
        //float roty = Mathf.SmoothDampAngle(transform.eulerAngles.y, player.transform.eulerAngles.y, ref speed, 1,400);

        //using SmoothStep Function interpolates between min,Max
        //float roty = Mathf.SmoothStep(transform.eulerAngles.y, player.transform.eulerAngles.y,1);

        // using LerpAngle Function make sure values  interpolates between  360 Angles correctly
        //float roty = Mathf.LerpAngle(transform.eulerAngles.y, player.transform.eulerAngles.y,Time.deltaTime);
        Quaternion rotation = Quaternion.Euler(new Vector3(0, rotateY, 0));
        transform.rotation = rotation;
        transform.position = player.transform.position + rotation * offset;
        transform.LookAt(player.transform);
  
        

    }
}
