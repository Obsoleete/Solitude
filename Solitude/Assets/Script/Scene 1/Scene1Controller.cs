﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Controller : MonoBehaviour
{

    private Material _objectLight;
    private float _threshold;

    public AudioSource laptopSFX;
    private Scene1LaptopController _laptopController;
    int hasInteracted;

    // Start is called before the first frame update
    void Start()
    {

        _objectLight = (Material)Resources.Load("InvertMaterial", typeof(Material));
        _threshold = _objectLight.GetFloat("_Threshold");
        _threshold = 0.0f;
        _objectLight.SetFloat("_Threshold", _threshold);

        _laptopController = GameObject.FindObjectOfType<Scene1LaptopController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
