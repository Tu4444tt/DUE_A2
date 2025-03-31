using UnityEngine;
using UnityEngine.SceneManagement; // ✅ 需要 Scene 管理库

public class SceneSwitcher : MonoBehaviour
{
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene"); // 🎯 加载名为 "SampleScene" 的场景
    }
}
