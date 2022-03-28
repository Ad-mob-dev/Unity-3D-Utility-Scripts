using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Scriptable Object Refrence
    [SerializeField]
    private CharacterGenerator characterData;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.name = characterData.playerName;
        gameObject.GetComponent<MeshRenderer>().material = characterData.material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,Vertical * characterData.forwardSpeed * Time.deltaTime));
           
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, Vertical * characterData.forwardSpeed * Time.deltaTime));

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Horizontal * characterData.rotationAngle * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Horizontal * characterData.rotationAngle * Time.deltaTime, 0));
        }



    }
}
