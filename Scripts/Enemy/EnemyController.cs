using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    float distance;
    public int health = 100;
    public ParticleSystem DieEffect;
    public ParticleSystem HitEffect;
    // Start is called before the first frame update
    void Start()
    {
        distance = Vector3.Distance(transform.position, Target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y, Target.transform.position.z + 4), Time.deltaTime);
        HealthValidator();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            HitEffect.GetComponent<ParticleSystem>().Play();
            HealthManager();

        }
    }

    void HealthManager()
    {
        if (health > 0) {
            health -= 10;
        }
      
    }
    void HealthValidator()
    {

        if (health == 0)
        {
            DieEffect.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject,2f);
        }
          
    }
}
