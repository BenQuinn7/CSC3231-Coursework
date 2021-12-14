using System.Text;
using Unity.Profiling;
using UnityEngine;
using TMPro;

public class MemoryDisplay : MonoBehaviour
{

    public TextMeshProUGUI memoryUsage;
    ProfilerRecorder systemUsedMemoryRecorder;

    void OnEnable()
    {
        systemUsedMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "System Used Memory");
    }

    void Update()
    {
        var sb = new StringBuilder(500);
        if (systemUsedMemoryRecorder.Valid)
            // Divide by (1024 * 1024) to get the value in MB. 
            sb.AppendLine($"System Used Memory: {systemUsedMemoryRecorder.LastValue / (1024 * 1024)} MB");
        memoryUsage.text = sb.ToString();
    }
}
