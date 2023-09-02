using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Face : MonoBehaviour
{

    public Transform controller;
    public float perTiling = 0.3f;
    Material faceMaterial;
    private float xTilling = 0f;


    // Start is called before the first frame update
    void Start()
    {
        faceMaterial = GetComponent<Renderer>().material;
      
        xTilling = faceMaterial.mainTextureScale.x;

        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 rotation = Quaternion.ToEulerAngles(controller.rotation);
        float newOffset = controller.eulerAngles.x/perTiling * xTilling;
        faceMaterial.mainTextureOffset = new Vector2(newOffset, 0);
    }
}
