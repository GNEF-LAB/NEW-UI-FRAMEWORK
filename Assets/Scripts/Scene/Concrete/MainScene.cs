using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : SceneState
{
    /// <summary>
    /// 场景名称
    /// </summary>
    readonly string sceneName = "Main";
    PanelManager panelManager;
    public override void OnEnter()
    {
        panelManager = new PanelManager();
        SceneManager.LoadScene(sceneName);
        if (SceneManager.GetActiveScene().name != sceneName)
        {
            SceneManager.LoadScene(sceneName);
            SceneManager.sceneLoaded += SceneLoaded;
        }
        else
        {
            panelManager.Push(new StartPanel());
            GameRoot.Instance.SetAction(panelManager.Push);
        }
    }

    public override void OnExit()
    {
        SceneManager.sceneLoaded
            -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode load)
    {
        panelManager.Push(new MainPanel());
        GameRoot.Instance.SetAction(panelManager.Push);
        Debug.Log($"{sceneName}加载完毕");
    }
}
