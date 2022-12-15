using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBlockGame : MonoBehaviour
{
    public AudioSource brick;
    // Start is called before the first frame update
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject obj17;
    public GameObject obj18;
    public GameObject obj19;
    public GameObject obj20;
    public GameObject obj21;
    public GameObject obj22;
    public GameObject obj23;
    public GameObject obj24;
    public GameObject obj25;
    public GameObject obj26;
    public GameObject obj27;
    public GameObject obj28;
    public GameObject obj29;
    public GameObject obj30;
    public GameObject obj31;
    public GameObject obj32;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "LeftHand")
        {
            brick.Play();
            obj1.active = true;
            obj2.active = true;
            obj3.active = true;
            obj4.active = true;
            obj5.active = true;
            obj6.active = true;
            obj7.active = false;
            obj8.active = false;
            obj9.active = false;
            obj10.active = false;
            obj11.active = false;
            obj12.active = false;
            obj13.active = false;
            obj14.active = false;
            obj15.active = false;
            obj16.active = false;
            obj17.active = false;
            obj18.active = false;
            obj19.active = false;
            obj20.active = false;
            obj21.active = false;
            obj22.active = false;
            obj23.active = false;
            obj24.active = false;
            obj25.active = false;
            obj26.active = false;
            obj27.active = false;
            obj28.active = false;
            obj29.active = false;
            obj30.active = false;
            obj31.active = false;
            obj32.active = false;
        }
    }
}
