using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
            private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
        Destroy(gameObject,(Random.Range(5f,12f)));
        }
        if (collision.gameObject.tag == ("Ground"))
        {
        Destroy(gameObject,(Random.Range(10f,20f)));
        }
    }
}
