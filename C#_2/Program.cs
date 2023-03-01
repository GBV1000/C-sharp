string[] array0 = {"hello", "2", "world", ":-)"};  
string[] final = {};

    foreach (var item in array0) {
        int test = item.Length;        
        if (item.Length < 4)
            final = final.Append(item).ToArray();
            
    
        
    }

Console.WriteLine('[' + String.Join(",", final) + "]");