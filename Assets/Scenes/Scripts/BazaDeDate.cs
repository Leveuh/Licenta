using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using TMPro;
using UnityEngine.UI;

public class BazaDeDate : MonoBehaviour
{
    public static class UsernameSave
    {
        public static string User;
        public static float MaxFrames;
        public static float MinFrames;
        public static float NrZomb;


    }

    private string DataBaseName = "URI=file:Components.db";

    public InputField Username;
    public TextMeshProUGUI GpuName;
    public TextMeshProUGUI GpuMemorySize;
   
  
    
    public void CreateDataBase()
    {

        using( var connect = new SqliteConnection(DataBaseName))
        {
            connect.Open();

            using (var command = connect.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS results (Username VARCHAR(10), GpuName VARCHAR(30),GpuMemorySize INT, GpuScore INT, MaxFps INT, MinFps INT, NumberOfZombies INT, Seconds INT);";
                command.ExecuteNonQuery();
            }
            connect.Close();

        }
    }



    void Start()
    {
        CreateDataBase();
    }

   public void AddComponents()
    {

        
        
        using( var connect = new SqliteConnection(DataBaseName))
        {
            connect.Open();
            using (var command = connect.CreateCommand())
            {

                command.CommandText = "INSERT INTO results(GpuName,GpuMemorySize) VALUES ('" + GpuName.text + "' , '" + GpuMemorySize + "');";
                command.ExecuteNonQuery();


            }
            connect.Close();
        }

    }

    public void AddUser()
    {
        BazaDeDate.UsernameSave.User = Username.text;
      

        using (var connect = new SqliteConnection(DataBaseName))
        {
            connect.Open();
            using (var command = connect.CreateCommand())
            {

                command.CommandText = "INSERT INTO results(Username) VALUES ('" + Username.text + "');";

                command.ExecuteNonQuery();


            }
            connect.Close();
        }
    }


  



    void Update()
    {
        
    }
}
