using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{
    public static class BuildCMICreator
    {
        public static List<string> m_arrBuildPaths = new()
            {"Assets/Scenes/SampleScene.unity",
        "Assets/Scenes/Test.unity"};
        public static void Build()
        {

            foreach (var s in EditorBuildSettings.scenes)
            {
                if (m_arrBuildPaths.Exists(q => q == s.path))
                    s.enabled = true;
                else
                    s.enabled = false;
            }
            

        }
    }
}
