﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 读取csv格式数据表（逗号隔开的数据格式）
/// </summary>
public class ConfigData
{
    private Dictionary<int, Dictionary<string, string>> datas;//每个数据表存储的数据到字典中，key时字典的id，值是每一行的数据
    public string fileName;//配置表文件名称

    public ConfigData(string fileName)
    {
        this.fileName = fileName;
        this.datas = new Dictionary<int, Dictionary<string, string>>();
    }

    public TextAsset LoadFile()
    {
        return Resources.Load<TextAsset>($"Data/{fileName}");
    }

    //读取
    public void Load(string txt)
    {
        string[] dataArr = txt.Split("\n", StringSplitOptions.RemoveEmptyEntries);//换行
        string[] titleArr = dataArr[0].Trim().Split(",");//逗号切割，获得第一行数据作为每行数据中字典的key值
        //内容从第三行开始读取（下标从2开始）
        for(int i = 2;i < dataArr.Length;i++)
        {
            string[] tempArr = dataArr[i].Trim().Split(",");
            Dictionary<string, string> tempData = new Dictionary<string, string>();
            for(int j = 0; j < tempArr.Length; j++)
            {
                tempData.Add(titleArr[j], tempArr[j]);
            }
            datas.Add(int.Parse(tempData["Id"]), tempData);
        }
    }

    public Dictionary<string,string> GetDataById(int id)
    {
        if(datas.ContainsKey(id))
        {
            return datas[id];
        }
        return null;
    }

    public Dictionary<int,Dictionary<string,string>> GetLines()
    {
        return datas;
    }
}
