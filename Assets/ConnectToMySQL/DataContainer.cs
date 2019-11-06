using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    // Datas to send. The table they correspond to is test_logs_upload, located in the vr_rehab database
    private Dictionary<string, List<string>> a = new Dictionary<string, List<string>>(){
        {"Email", new List<string>(){"random.address@potato.dk"}},
        {"intField", new List<string>(){"0123456789"}},
        {"floatField", new List<string>(){"3.141519"}},
        {"dateField", new List<string>(){"04-11-2019 15:29:50"}}
    };
    
    public void SendDatas()
    {
        ConnectToMySQL connectToMySql = gameObject.GetComponent<ConnectToMySQL>();
        connectToMySql.AddToUploadQueue(a);
        connectToMySql.UploadNow();
    }
}