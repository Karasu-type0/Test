using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;

public class NativeAPI : MonoBehaviour
{

//NaitivePluginの確保、MacOS(bundle)iOS(.a, framwork)
#if UNITY_EDITOR
        [DllImport("Test")]
#elif UNITY_IOS
        [DllImport("__Internal")]
#endif
        private static extern int test();
        public static int Test()
        {
#if UNITY_IOS || UNITY_EDITOR
            return test();
#endif
        }

#if UNITY_EDITOR
        [DllImport("Test")]
#elif UNITY_IOS
        [DllImport("__Internal")]
#endif
        private static extern float floatPlugin();
        public static float FloatPlugin()
        {
#if UNITY_IOS || UNITY_EDITOR
            return floatPlugin();
#else
            return 0;
#endif
        }

#if UNITY_EDITOR
        [DllImport("Test")]
#elif UNITY_IOS
        [DllImport("__Internal")]
#endif
        private static extern string charPlugin(string str);
        public static string CharPlugin(string str)
        {
#if UNITY_IOS || UNITY_EDITOR
            return charPlugin(str);
#endif
        }

#if UNITY_EDITOR
        [DllImport("Test")]
#elif UNITY_IOS
        [DllImport("__Internal")]
#endif
        private static extern string cgalTest(string inStr, string outStr);
        public static string CgalTest(string inStr, string outStr)
        {
#if UNITY_IOS || UNITY_EDITOR
            return cgalTest(inStr, outStr);
#endif
        }


        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("整数型 : " + Test());
            Debug.Log("実数型 : " + FloatPlugin());
            Debug.Log("文字列型 : " + CharPlugin("hogehoge"));


//#if !UNITY_EDITOR
//            UnityEngine.iOS.Device.SetNoBackupFlag(Application.persistentDataPath);
//            var _savePath = Application.persistentDataPath + "/DebugFolder";
//            Directory.CreateDirectory(_savePath);
//#elif UNITY_EDITOR
//            var _savePath = Application.dataPath + "/DebugFolder";
//            Directory.CreateDirectory(_savePath);
//#endif


//            string instr = _savePath + "/" + _fileName;
//            string outstr = _savePath + "/" + _fileName + "_SurfaceRecon.obj";
//            Debug.Log("" + CgalTest(instr, outstr));

        }

    }
