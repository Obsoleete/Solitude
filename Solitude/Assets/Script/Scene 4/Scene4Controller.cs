﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Controller : MonoBehaviour
{

    public Animator bedAnimator;
    public AudioSource errorSFX;
    public AudioSource laptopSFX;

    private Material _objectLight;
    private float _threshold;

    private LaptopController _laptopController;
    int hasInteracted;
    private bool _checkLights;

    // Start is called before the first frame update
    void Start()
    {
        _laptopController = GameObject.FindObjectOfType<LaptopController>();
        bedAnimator.Play("Base Layer.New BedAnimation", 0, 0);

        _objectLight = (Material)Resources.Load("InvertMaterial", typeof(Material));
        _threshold = _objectLight.GetFloat("_Threshold");
        _threshold = 1f;
        _objectLight.SetFloat("_Threshold", _threshold);

    }

    // Update is called once per frame
    void Update()
    {
        _threshold = _objectLight.GetFloat("_Threshold");
        _checkLights = _threshold == 0;
        hasInteracted = _laptopController.InteractedWithLaptop();

        if (!_checkLights && hasInteracted > 0) {
            errorSFX.Play(); 
        }

        if (_checkLights && hasInteracted > 0) {
            laptopSFX.Play();
        }
    }

    public bool CheckLights() {
        return _checkLights;
    }
}