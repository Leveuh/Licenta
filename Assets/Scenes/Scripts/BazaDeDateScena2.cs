using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using TMPro;
using UnityEngine.UI;
public class BazaDeDateScena2 : MonoBehaviour
{
    private string DataBaseName = "URI=file:Components.db";


    public Text MaxFps;
    public Text MinFps;
    public Text NumberOfZombies;
  
    public Text Seconds;


    public void AddComponents()
    {

       

        using (var connect = new SqliteConnection(DataBaseName))
        {
            connect.Open();
            using (var command = connect.CreateCommand())
            {
              
                
               command.CommandText = "INSERT INTO results(MaxFps,MinFps,NumberOfZombies,Seconds) VALUES ('" + MaxFps.text + "' , '" + MinFps.text + "' , '"+ NumberOfZombies.text + "', '" + Seconds.text + "');";
                command.ExecuteNonQuery();


            }
            connect.Close();
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
