//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年6月9日 14:08:27
//------------------------------------------------------------

using UnityEditor;
using UnityEngine;

namespace GraphProcessor
{
    public static class GraphSaveHelper
    {
        public static void SaveGraphToDisk(BaseGraph baseGraphToSave)
        {
            EditorUtility.SetDirty(baseGraphToSave);
            AssetDatabase.SaveAssets();
        }
    }
}