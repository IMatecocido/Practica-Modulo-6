using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public GameObject Cubo;
    private void Awake()
    {
        Instantiate(Cubo);
        Cubo.transform.position = new Vector3(0, 0, 10);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
