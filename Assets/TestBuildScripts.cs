using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityBuilderAction
{
    public static class TestBuildScripts
{
       /* private static readonly List<string> m_scenePaths = new()
            {
            "Assets/Scenes/SampleScene.unity",
            "Assets/Scenes/Test.unity"
        };

        public static void Build()
        {
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.WebGL, ScriptingImplementation.IL2CPP);
            PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;
            List<EditorBuildSettingsScene> m_editorBuildSettingsScenes = new();
            Debug.Log(EditorBuildSettings.scenes.Length);
            foreach (var s in EditorBuildSettings.scenes)
            {
                if(m_scenePaths.Find(q => q == s.path) != null)
                    m_editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(s.path, true));
                else
                    m_editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(s.path, false));

            }
            Debug.Log(m_editorBuildSettingsScenes.Count);
            EditorBuildSettings.scenes = m_editorBuildSettingsScenes.ToArray();
            m_editorBuildSettingsScenes.Clear();
        }
       */
    }
}
