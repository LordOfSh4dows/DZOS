using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removes2 : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 posd;
    int x,y,z = 0;
    private Vector3 posm;
    private Vector3 scale;
    private Quaternion qua;
    private Vector3 scalerig;
    // Start is called before the first frame update
    public Rigidbody Obj;
    void Start()
    {
        scale=transform.localScale;
        scalerig=Obj.transform.localScale;
        pos=transform.position-scale/2+scalerig/2;
        posd=pos;
        posm=transform.position+scale/2-scalerig/2;
        while (pos.x<=posm.x)
        {
            while (pos.y<=posm.y)
            {
                while (pos.z<=posm.z)
                {
                    z+=1;
                    pos=pos+(new Vector3(0,0,1)*scalerig.z);
                }
            y+=1;
            pos=pos+(new Vector3(0,1,0)*scalerig.y);
            }
        x+=1;
        pos=pos+(new Vector3(1,0,0)*scalerig.x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        qua=transform.rotation;
        posd=transform.position-qua*scale/2+qua*scalerig/2;

    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            for (int X0=0; X0<x; X0++)
            {
                for (int Y0=0; Y0<y; Y0++)
                {
                    for (int Z0=0; Z0<y; Z0++)
                    {
                        Instantiate(Obj,(posd+qua*new Vector3(0,0,1)*Z0*scalerig.z+qua*new Vector3(0,1,0)*Y0*scalerig.y+qua*new Vector3(1,0,0)*X0*scalerig.x) ,qua);
                    }
                }
            }

        Destroy(gameObject);
        }
    }
    }

