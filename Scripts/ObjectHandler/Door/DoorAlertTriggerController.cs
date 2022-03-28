
using UnityEngine;

public class DoorAlertTriggerController : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("openDoor",true);
        Debug.Log("hey");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("openDoor", false);
    }


}
