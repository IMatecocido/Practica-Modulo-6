using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booleanas : MonoBehaviour
{
    public GameObject cubo;
    public GameObject cubo2;
    public GameObject cubo3;
    public GameObject cubo4;
    public GameObject cubo5;
    bool variable1;
    bool variable2;
    bool variable3;
    bool variable4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (variable1)
        {
            cubo.GetComponent<MeshRenderer>().material.color = Color.white;
            variable1 = false;
        }
        else
        {
            cubo.GetComponent<MeshRenderer>().material.color = Color.black;
            variable1 = true;
        }
        if (variable2)
        {
            cubo2.GetComponent<MeshRenderer>().material.color= Color.white;
            variable2 = false;
        }
        else
        {
            cubo2.GetComponent<MeshRenderer>().material.color=Color.black;
            variable2 = true;
        }
        if (variable1 && variable2)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = Color.white;
            variable3 = false;
        }
        else
        {
            cubo3.GetComponent<MeshRenderer>().material.color = Color.black;
            variable3 = true;
        }
        if (variable1 || variable2)
        {
            cubo4.GetComponent<MeshRenderer>().material.color = Color.white;
            variable4 = false;
        }
        else
        {
            cubo4.GetComponent<MeshRenderer>().material.color = Color.black;
            variable4 = true;
        }
        if (variable4 && variable3)
        {
            cubo5.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            cubo5.GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }

}

