﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 主场景面板
/// </summary>
public class MainPanel : BasePanel
{
    static readonly string path = "Prefabs/UI/Panel/MainPanel";
    public MainPanel() : base(new UIType(path)) { }

    public override void OnEnter()
    {
        UITool.GetOrAddComponentInChildren<Button>("BtnQuit").onClick.AddListener(() => {
            GameRoot.Instance.SceneSystem.SetScene(new StartScene());
            Pop();
        });
        UITool.GetOrAddComponentInChildren<Button>("BtnMsg").onClick.AddListener(() => {
            Push(new TaskPanel());
        });

        UITool.GetOrAddComponentInChildren<Button>("BtnSetting").onClick.AddListener(() => {
            Push(new SettingPanel());
        });
    }
}
