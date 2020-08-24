﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 存储所有UI信息，并可以创建或者销毁UI
/// </summary>
public class UIManager 
{
    /// <summary>
    /// 存储所有UI信息的字典，每一个UI信息都会对应一个GameObject
    /// </summary>
    private Dictionary<UIType, GameObject> dicUI;
    GameObject parent;

    public UIManager()
    {
        dicUI = new Dictionary<UIType, GameObject>();
        parent = GameObject.Find("Canvas");
    }

    /// <summary>
    /// 获取一个UI对象
    /// </summary>
    /// <param name="type">UI信息</param>
    /// <returns></returns>
    public GameObject GetSingleUI(UIType type)
    {
        
        if (!parent)
        {
            Debug.LogError("Canvas不存在，请确认有无这个对象");
        }
        if (dicUI.ContainsKey(type))
        {
            return dicUI[type];

        }
        GameObject ui = GameObject.Instantiate(Resources.Load<GameObject>(type.Path), parent.transform);
        ui.name = type.Name;
        dicUI.Add(type,ui);
        return ui;
    }

    /// <summary>
    /// 销毁一个UI对象
    /// </summary>
    /// <param name="type">UI信息</param>
    public void DestroyUI(UIType type)
    {
        if (dicUI.ContainsKey(type))
        {
            GameObject.Destroy(dicUI[type]);
            dicUI.Remove(type);
        }
    }
}
