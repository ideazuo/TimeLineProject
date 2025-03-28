﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
///<summary>
///单例基类
///</summary>
public class Singleton<T>
{
    private static readonly T instance = Activator.CreateInstance<T> ();
    public static T Instance
    {
        get
        {
        return instance;
        }
        
    }

    //初始化
    public virtual void Init()
    {

    }

    //每帧执行
    public virtual void Update(float dt)
    {

    }

    //释放
    public virtual void OnDestroy()
    {

    }
}

