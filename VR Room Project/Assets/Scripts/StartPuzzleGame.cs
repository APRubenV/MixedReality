using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPuzzleGame : MonoBehaviour
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
            obj1.active = false;
            obj2.active = false;
            obj3.active = false;
            obj4.active = false;
            obj5.active = false;
            obj6.active = false;
            obj7.active = false;
            obj8.active = false;
            obj9.active = false;
            obj10.active = false;
            obj11.active = false;
            obj12.active = false;
            obj13.active = false;
            obj14.active = false;
            obj15.active = true;
            obj16.active = true;
            obj17.active = true;
            obj18.active = true;
            obj19.active = true;
            obj20.active = true;
            obj21.active = true;
            obj22.active = true;
            obj23.active = true;
            obj24.active = true;
            obj25.active = true;
            obj26.active = true;
            obj27.active = true;
            obj28.active = true;
            obj29.active = true;
            obj30.active = true;
            obj31.active = true;
            obj32.active = true;
        }
    }
}
