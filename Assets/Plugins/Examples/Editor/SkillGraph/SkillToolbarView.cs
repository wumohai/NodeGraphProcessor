//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年5月31日 19:15:32
//------------------------------------------------------------

using GraphProcessor;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Examples.Editor._05_All
{
    public class SkillToolbarView : NPBehaveToolbarView
    {
        public SkillToolbarView(BaseGraphView graphView, MiniMap miniMap, BaseGraph baseGraph) : base(graphView, miniMap, baseGraph)
        {
        }
        
        protected override void AddButtons()
        {
            base.AddButtons();
            
            AddCustom(() =>
            {
                GUI.color = new Color(128/255f,128/255f,128/255f);
                GUILayout.Label("黑板数据库_2", EditorGUIStyleHelper.GetGUIStyleByName(nameof(EditorStyles.toolbarButton)));
                GUI.color = Color.white;
            });
            
        }
    }
}