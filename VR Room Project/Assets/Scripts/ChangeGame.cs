using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGame : MonoBehaviour
{
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
    private bool isGame1;
    // Start is called before the first frame update
    void Start()
    {
        isGame1 = true;   
    }

    public void StartBlockGameFun()
    {
        if (isGame1)
        {
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
        }
    }
}
