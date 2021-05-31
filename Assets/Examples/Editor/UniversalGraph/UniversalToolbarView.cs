//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年5月31日 19:15:32
//------------------------------------------------------------

using GraphProcessor;
using UnityEditor;
using UnityEditor.UIElements;

namespace Examples.Editor._05_All
{
    public class UniversalToolbarView : ToolbarView
    {
        private MiniMapView m_MiniMapView;
        
        public UniversalToolbarView(BaseGraphView graphView, MiniMapView miniMapView) : base(graphView)
        {
            m_MiniMapView = miniMapView;
        }
        
        protected override void AddButtons()
        {
            base.AddButtons();
            bool miniMapVisible = m_MiniMapView.visible;
            AddToggle("Show MiniMap", miniMapVisible, (v) => m_MiniMapView.visible = v);
        }
    }
}