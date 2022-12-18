using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pod : MonoBehaviour
{
    public GameObject Crasca;
    
    public Renderer rend;

    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("cliced");
        rend.material.color = new Color(0,255,0,0);
    }

}
