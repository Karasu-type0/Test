using System.IO;
using UnityEngine;

public class Test : MonoBehaviour
{
    /// <summary>
    /// ImportFileFormat : .xyz or .ply or .off
    /// </summary>
    [SerializeField]
    private string _fileName = "kitten.xyz";

    // Start is called before the first frame update
    void Start()
    {
        string _savePath = Application.dataPath + "/Debug";
        Directory.CreateDirectory(_savePath);

        string instr = _savePath + "/" + _fileName;
        string outstr = _savePath + "/" + _fileName + "_SurfaceRecon.obj";

        Debug.Log("整数型 : " + NativeAPI.Test());
        Debug.Log("実数型 : " + NativeAPI.FloatPlugin());
        Debug.Log("文字列型 : " + NativeAPI.CharPlugin("hogehoge"));
        Debug.Log("SurfaceRecon : " + NativeAPI.CgalTest(instr, outstr));
    }
}
