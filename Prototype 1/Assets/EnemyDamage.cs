using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update 
    float Health = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Health);

        if (Health <= 0)
        {
            Destroy(gameObject); 
            
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Melee")
        {
            Debug.Log("hit target");
            Destroy(gameObject);
            //Health -= 20f;
        } 
    }
}
