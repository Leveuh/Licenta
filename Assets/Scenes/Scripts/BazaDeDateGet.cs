using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BazaDeDateGet : MonoBehaviour
{
    private string DataBaseName = "URI=file:Components.db";

    public Text Username;
    public string GpuName = "Empty";
    public Text GpuName_Text;
    public string GpuMemorySize = "0";
    public Text GpuMemorySize_Text;
    public Text MaxFps;
    public Text MinFps;
    public Text NumberOfZombies;
    public Text Score;
    public Text Percent;
   
    public Text Seconds;

    private void Start()
    {
        Username.text = BazaDeDate.UsernameSave.User;
    }
    public void Gpu()
    {
        GpuMemorySize = SystemInfo.graphicsMemorySize.ToString();
        GpuMemorySize_Text.text = string.Format(GpuMemorySize, GpuMemorySize.ToString());

        GpuName = SystemInfo.graphicsDeviceName.ToString();
        GpuName_Text.text = string.Format(GpuName, GpuName.ToString() + SystemInfo.graphicsDeviceType.ToString() + SystemInfo.graphicsDeviceVendor.ToString() + SystemInfo.graphicsDeviceVendorID.ToString());


    }
    public void TakeData()
    {
        using (var connect = new SqliteConnection(DataBaseName))
        {
            connect.Open();
            using (var command = connect.CreateCommand())
            {
                command.CommandText = "SELECT * FROM results;";
                
                using (IDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        
                           
                      
                           MaxFps.text = dataReader["MaxFps"].ToString();
                        float maximumfps = BazaDeDate.UsernameSave.MaxFrames;
                            MinFps.text = dataReader["MinFps"].ToString();
                        float minimumfps = BazaDeDate.UsernameSave.MinFrames;
                        NumberOfZombies.text = dataReader["NumberOfZombies"].ToString();
                        float numberofz = BazaDeDate.UsernameSave.NrZomb;
                        Seconds.text = dataReader["Seconds"].ToString();

                        float score = (maximumfps * 0.1f + minimumfps * 0.9f) * numberofz;
                        Score.text = score.ToString();


                        float average = 70996;
                        float percent = Mathf.Abs(score - average) / average * 100;
                        if(score > average)
                        {
                            Percent.text = percent.ToString() + "% better";
                        }
                        else
                        {
                            Percent.text = percent.ToString() + "% worse";
                        }

                        


                    }
                    dataReader.Close();


                }


            }
            connect.Close();
        }
    }
}