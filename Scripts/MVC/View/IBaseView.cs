﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//视图接口
public interface IBaseView
{
    bool IsInit();//视图是否已经初始化

    bool IsShow();//是否现实

    void InitUI();//初始化面板

    void InitData();//初始化数据

    void Open(params object[] args);//打开面板

    void Close(params object[] args);//关闭面板

    void DestroyView();//删除面板

    void ApplyFunc(string eventName, params object[] args);//触发本模块事件

    void ApplyControllerFunc(int controller, string eventName, params object[] args);//触发其它控制器模块事件

    void SetVisable(bool value);//设置显示隐藏

    int ViewId { get; set; }//面板Id

    BaseController Controller { get; set; }//面板所属控制器
}
