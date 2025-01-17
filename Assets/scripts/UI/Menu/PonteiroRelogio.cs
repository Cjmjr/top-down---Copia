﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonteiroRelogio : MonoBehaviour
{
    private RectTransform transformPonteiro;
    private void Awake()
    {
        transformPonteiro = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;// Camera.main.nearClipPlane;
        Vector3 relativo = transformPonteiro.transform.position - mousePos;
        float angulo = Mathf.Atan2(relativo.y, relativo.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, -angulo - 90) * -1;
    }
}
