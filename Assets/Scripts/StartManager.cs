using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    PanelManager panelManager;
    // Start is called before the first frame update
    void Awake()
    {
        panelManager = new PanelManager();
    }

    // Update is called once per frame
    void Start()
    {
        panelManager.Push(new StartPanel());
    }
}
