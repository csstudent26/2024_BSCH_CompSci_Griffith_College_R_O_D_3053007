using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Material testMat;//Creating a Public Variable, which is accessable to all
    void Start()
    {
        testMat = GetComponent<MeshRenderer>().material;// Getting Value of Objects MeshRenderer and assiging it to 'testMat
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){

        testMat.color = Random.ColorHSV();//Using Built In Random Class to Chose Random Color
    }
}
