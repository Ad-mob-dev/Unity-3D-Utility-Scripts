using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxHandler : MonoBehaviour
{ 
    public ParticleSystem Electric;
    public ParticleSystem FireWorkTrials;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Electric.GetComponent<ParticleSystem>().Play();
            FireWorkTrials.GetComponent<ParticleSystem>().Play();
        }
    }
}
