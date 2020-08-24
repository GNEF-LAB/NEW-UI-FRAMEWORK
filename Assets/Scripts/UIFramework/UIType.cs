using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIType
{
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 路径
    /// </summary>
    public string Path { get; private set; }

    public UIType(string path)
    {
        this.Path = path;
        this.Name = path.Substring(path.LastIndexOf('/') + 1);
    }
}
