using System.Net;
using System.Security.AccessControl;
using System.IO;
using System.ComponentModel.DataAnnotations;
//add?
// dotnet add package Newtonsoft.Json --vergit sion 13.0.3;
using Newtonsoft.Json;
namespace FileService;


public class ReadWrite<T>:IFileService<T>
{
    private readonly string _path;
    public ReadWrite(string path)
    {
        _path = path;
    }
    public List<T> Read()
    {
        var list = new List<T>();
        var text = File.ReadAllText(_path);
        if (!string.IsNullOrEmpty(text))
        {
            list = JsonConvert.DeserializeObject<List<T>>(text);
        }
        return list;
    }
    public void Write(T obj)
    {
        var list = Read();
        list.Add(obj);
        File.WriteAllText(_path, JsonConvert.SerializeObject(list));
    }                      
}
