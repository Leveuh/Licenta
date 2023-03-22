using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PCSpecsMenu : MonoBehaviour
{
    public string GpuName = "Empty";
    public Text GpuName_Text;

    public string GpuMemorySize = "0";
    public Text GpuMemorySize_Text;

    public string GpuVersion = "0";
    public Text GpuVersion_Text;

    public string GpuMultiThreading = "0";
    public Text GpuMultiThreading_Text;

    public string GpuShader= "0";
    public Text GpuShader_Text;

    public string CpuType = "0";
    public Text CpuType_Text;

    public string CpuFrequency = "0";
    public Text CpuFrequency_Text;

    public string CpuCount = "0";
    public Text CpuCount_Text;

    public string Memory = "0";
    public Text Memory_Text;

    public string OS = "0";
    public Text OS_Text;
    public void StressTest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GetComponents() {

        GpuName = SystemInfo.graphicsDeviceName.ToString();
        GpuName_Text.text = string.Format(GpuName, GpuName.ToString() + SystemInfo.graphicsDeviceType.ToString() + SystemInfo.graphicsDeviceVendor.ToString() + SystemInfo.graphicsDeviceVendorID.ToString() );
        


        GpuMemorySize = SystemInfo.graphicsMemorySize.ToString();
         GpuMemorySize_Text.text = string.Format(GpuMemorySize, GpuMemorySize.ToString());

        GpuVersion = SystemInfo.graphicsDeviceVersion.ToString();
        GpuVersion_Text.text = string.Format(GpuVersion, GpuVersion.ToString());

        GpuMultiThreading = SystemInfo.graphicsMultiThreaded.ToString();
        GpuMultiThreading_Text.text = string.Format(GpuMultiThreading, GpuMultiThreading.ToString());

        GpuShader = SystemInfo.graphicsShaderLevel.ToString();
        GpuShader_Text.text = string.Format(GpuShader, GpuShader.ToString());

        OS = SystemInfo.operatingSystem;
        OS_Text.text = string.Format(OS, OS.ToString());



        CpuCount = SystemInfo.processorCount.ToString();
        CpuCount_Text.text = string.Format(CpuCount, CpuCount.ToString());

        CpuFrequency = SystemInfo.processorFrequency.ToString();
        CpuFrequency_Text.text = string.Format(CpuFrequency, CpuFrequency.ToString());

        CpuType = SystemInfo.processorType.ToString();
        CpuType_Text.text = string.Format(CpuType, CpuType.ToString());

        Memory = SystemInfo.systemMemorySize.ToString();
        Memory_Text.text = string.Format(Memory, Memory.ToString());

    }


}
