using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Scripting.Python;
using UnityEditor;
using System.IO;

public class DataMaker
{
    [MenuItem("Python/mergeSort")]
    static void MergeSort()
    {
        string scriptPath = Path.Combine(Application.dataPath, "MergeSort.py");
        PythonRunner.RunFile(scriptPath);
    }
}
