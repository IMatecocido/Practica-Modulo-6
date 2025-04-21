using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    public GameObject Cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Cubo);
        Cubo.transform.position = new Vector3(0, 0, 5);
    }
}
