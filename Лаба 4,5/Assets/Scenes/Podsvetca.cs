using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Crasca;
    public byte J = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OneMouseDown()
    {
        Crasca.GetComponent<Image>().color = new Color32(0,J,0,0);
        J+=50;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
