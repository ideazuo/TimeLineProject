﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager
{
    private Transform camTf;//摄像机

    private Vector3 prePos;//之前位置

    public CameraManager()
    {
        camTf = Camera.main.transform;
        prePos = camTf.transform.position;
    }

    //设置摄像机位置
    public void SetPos(Vector3 pos)
    {
        pos.z = camTf.position.z;
        camTf.transform.position = pos;
    }

    public void ResetPos()
    {
        camTf.transform.position = prePos;
    }
}
