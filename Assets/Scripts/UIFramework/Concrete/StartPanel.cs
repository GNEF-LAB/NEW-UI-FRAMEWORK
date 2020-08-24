using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : BasePanel
{

    static readonly string path = "Prefabs/UI/Panel/StartPanel";
    public StartPanel() : base(new UIType(path)) { }

    public override void OnEnter()
    {
        UITool.GetOrAddComponentInChildren<Button>("BtnSetting").onClick.AddListener(() =>
        {
            //点击事件可以写在这里面
            Debug.Log("设置按钮被点击了");
            Push(new SettingPanel());
        });
        UITool.GetOrAddComponentInChildren<Button>("BtnPlay").onClick.AddListener(() =>
        {
            //点击事件可以写在这里面
            Debug.Log("Play按钮被点击了");
            GameRoot.Instance.SceneSystem.SetScene(new MainScene());
            //PanelManager.Push()
        });
    }
}
