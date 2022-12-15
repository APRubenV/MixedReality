using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRingGame : MonoBehaviour
{
    public AudioSource brick;
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
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "LeftHand")
        {
            brick.Play();
            obj1.active = false;
            obj2.active = false;
            obj3.active = false;
            obj4.active = false;
            obj5.active = false;
            obj6.active = false;
            obj7.active = true;
            obj8.active = true;
            obj9.active = true;
            obj10.active = true;
            obj11.active = true;
            obj12.active = true;
            obj13.active = true;
            obj14.active = true;
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
