using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System;

public static class Log
    {

    public static void saveToFile<T>(T t,string path) where T : class
    {
        StringBuilder sb = new StringBuilder();
        var get = t.GetType().GetProperties().ToList();

        
        sb.AppendLine($"Proprieta classe: ");
        foreach (var prp in get)
        {
            sb.AppendLine($"{prp.Name} \n{prp.GetValue(t)}");
        }

        File.AppendAllText(path, sb.ToString());
    }

  
}




    
    






