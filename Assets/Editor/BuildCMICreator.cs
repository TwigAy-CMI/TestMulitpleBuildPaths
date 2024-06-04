using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

namespace UnityBuilderAction
{
    public static class BuildCMICreator
    {
        public static List<string> m_arrBuildPaths = new()
            {"Assets/Scenes/SampleScene.unity",
        "Assets/Scenes/Test.unity"};
        public static void Build()
        {
            List<EditorBuildSettingsScene> newSceneList = new();
            foreach (var s in EditorBuildSettings.scenes)
            {
                if (m_arrBuildPaths.Exists(q => q == s.path))
                {
                    newSceneList.Add(new EditorBuildSettingsScene(s.path, true));
                }
                else
                {
                    Debug.Log(s.path + " Disabled");
                    newSceneList.Add(new EditorBuildSettingsScene(s.path, false));
                }
            }

            EditorBuildSettings.scenes = newSceneList.ToArray();
            //PlayerSettings.WebGL
            
        }
    }
}
