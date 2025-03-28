﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 统一定义游戏中的管理器，在此类进行初始化
/// </summary>
public class GameApp : Singleton<GameApp>
{
    public static SoundManager SoundManager;//音频管理文件

    public static ControllerManager ControllerManager;//控制器管理器

    public static ViewManager ViewManager;//视图管理器

    public static ConfigManager ConfigManager;//配置表

    public static MessageCenter MsgCenter;//消息监听

    public static CameraManager CameraManager;

    public static TimerManager TimerManager;

    public static GameDataManager GameDataManager;


    public override void Init()
    {
        TimerManager = new TimerManager();
        MsgCenter = new MessageCenter();
        CameraManager = new CameraManager();
        SoundManager = new SoundManager();
        ConfigManager = new ConfigManager();
        ControllerManager = new ControllerManager();
        ViewManager = new ViewManager();
        GameDataManager = new GameDataManager();
    }

    public override void Update(float dt)
    {
        TimerManager.OnUpdate(dt);
    }
}
