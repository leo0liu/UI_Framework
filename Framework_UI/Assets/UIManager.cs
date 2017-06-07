using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager  {
    private Dictionary<UIPanelType, string> panelPathDict;//存储所有面板Prefab路径


     private void ParseUIPanelTypeJson()
    {
        TextAsset ta=Resources.Load<TextAsset>("UIPanelTpe");
    }
}

