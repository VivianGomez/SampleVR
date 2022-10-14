using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCrtl : MonoBehaviour
{
    public GameObject cubo;
    public Material anterior;
    public Material nuevo;
    public Animator anim;
    bool isBlue = false;

    private void Start() {
        anim = GetComponent<Animator>();
        anterior = GetComponent<MeshRenderer>().material;
    }

    private IEnumerator OnTriggerEnter(Collider other) {
        if(other.name=="GrabVolumeBig")
        {
            if(!isBlue)
            {
                cubo.GetComponent<MeshRenderer>().material = nuevo;
                anim.SetTrigger("pressed");
                isBlue = true;
            }
            else
            {
                cubo.GetComponent<MeshRenderer>().material = anterior;
                anim.SetTrigger("pressed");
                isBlue = false;
            }
            yield return new WaitForSeconds(1);
            anim.SetTrigger("base");
        }
    }
}
