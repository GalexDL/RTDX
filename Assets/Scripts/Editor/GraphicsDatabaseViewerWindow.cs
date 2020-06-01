using SkyEditor.RomEditor.Rtdx.Domain;
using UnityEditor;
using UnityEngine;

public class GraphicsDatabaseViewerWindow : EditorWindow
{
    private RtdxRom _rom;

    private Vector2 _scrollPos;
    [MenuItem("Tools/Graphics Database Viewer", false)]
    static void Init()
    {
        GetWindow<GraphicsDatabaseViewerWindow>().Show();
    }

    private void OnEnable()
    {
        _rom = SkyEditorHelpers.GetRom();
    }

    private void OnGUI()
    {
        using (new EditorGUILayout.HorizontalScope())
        {
            using (new EditorGUI.IndentLevelScope())
            {
                EditorGUILayout.LabelField("", GUILayout.Width(50));
                EditorGUILayout.LabelField("Model");
                EditorGUILayout.LabelField("Animation");
                EditorGUILayout.LabelField("PortraitSheet");
                EditorGUILayout.LabelField("BaseFormModelName");
                EditorGUILayout.LabelField("WalkSpeedDistance");
            }
        }

        var names = _rom.GetCommonStrings().Pokemon;
        var formDbEntries = _rom.GetPokemonFormDatabase().Entries;
        var graphicsDbEntries = _rom.GetPokemonGraphicsDatabase().Entries;

        using (var scrollView = new EditorGUILayout.ScrollViewScope(_scrollPos))
        {
            _scrollPos = scrollView.scrollPosition;

            for (int i = 0; i < formDbEntries.Count; i++)
            {
                var formDbEntry = formDbEntries[i];
                using (new EditorGUILayout.HorizontalScope())
                {
                    EditorGUILayout.LabelField(i.ToString(), EditorStyles.boldLabel, GUILayout.Width(40));
                    EditorGUILayout.LabelField(((SkyEditor.RomEditor.Rtdx.Reverse.Const.creature.Index) i+1).ToString(), EditorStyles.boldLabel, GUILayout.Width(150));
                    EditorGUILayout.LabelField($"({names[(SkyEditor.RomEditor.Rtdx.Reverse.Const.creature.Index) i+1]})", EditorStyles.boldLabel);
                }
                foreach (var graphicsDatabaseEntryId in formDbEntry.PokemonGraphicsDatabaseEntryIds)
                {
                    if (graphicsDatabaseEntryId == 0 || graphicsDatabaseEntryId + 1 >= graphicsDbEntries.Count)
                        continue;

                    using (new EditorGUI.IndentLevelScope())
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            var entry = graphicsDbEntries[graphicsDatabaseEntryId - 1];
                            EditorGUILayout.LabelField((graphicsDatabaseEntryId - 1).ToString(), GUILayout.Width(50));
                            EditorGUILayout.LabelField(entry.ModelName);
                            EditorGUILayout.LabelField(entry.AnimationName);
                            EditorGUILayout.LabelField(entry.PortraitSheetName);
                            EditorGUILayout.LabelField(entry.BaseFormModelName);
                            EditorGUILayout.LabelField(entry.WalkSpeedDistance.ToString());
                        }
                    }
                }
            }
        }
    }
}
