﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public float noteSpeed = 400;
    //UnityEngine.UI.Image noteImage;

    // Start is called before the first frame update
    //void Start()
    //{
    //    noteImage = GetComponent<UnityEngine.UI.Image>();
    //}

    //public void HideNote()
    //{
    //    noteImage.enabled = false;
    //}

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.right * noteSpeed * Time.deltaTime;
    }
}
