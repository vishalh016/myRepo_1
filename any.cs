using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Collections.Generic.KeyValuePair;

class Program
{
    static void Main(string[] args)
    {    
        Console.WriteLine("Enter the number of details:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the address details:");
        Dictionary<string, List<Address>> d=new Dictionary<string, List<Address>>();
        // List<Address> l=new List<Address>();
        string[] str=new string[n];
        for (int i = 0; i < n; i++) 
        {
			//fill your code here
            str[i]=Console.ReadLine();
            // string[] s=str[i].Split(",");
            // Address a=new Address(s[0],s[1],s[2],s[3],int.Parse(s[4]));
            
            // if(!d.ContainsKey(s[2])){
            //     d.Add()
            // }
        }
        Console.WriteLine("Enter the city to view:");
        string city = Console.ReadLine();
        //fill your code here
        for(int i=0;i<n; i++){
            List<Address> l=new List<Address>();
            string[] s1=str[i].Split(",");
            string key=s1[2];
            for(int j=i;j<l.Count;j++){
                
                string[] s=str[j].Split(",");
                if(key==s[2]){
                    Address a=new Address(s[0],s[1],s[2],s[3],int.Parse(s[4]));
                    l.Add(a);
                }            
            }
            if(!d.ContainsKey(key)){
                d.Add(key,l);
            }
        }
        bool f=false;
        foreach(KeyValuePair<string,List<Address>> it in d){
            if(it.Key==city){
                f=true;
                List<Address> l=it.Value;
                for(int j=0;j<l.Count;j++){
                    // l[j].ToString;
                    Address ad=(Address)l[j];
                    ad.ToString();
                }
                // foreach(Address j in i.value){

                // }
            }
            if(!f){
               Console.WriteLine("Address Details for the selected city not found..."); 
            }
        }
        //     List<Address> ml=new List<Address>();
        //     for(int j=i;j<l.Count;j++){
        //         ml.Add(l[i]);
        //         if(l[i].City==l[j].City){
        //             ml.Add(l[j]);
        //             l.RemoveAt(j);
        //         }
        //     }
        //     d.Add(l[i].City,ml);
        //     l.RemoveAt(i);
        // }
        // Console.WriteLine(l);
        // 
        // foreach(var item  in d){
        //     if(item.Key==city){
        //         f=true;
        //         item.Value.ToString();
        //     }
        // }
        // if(!f){
        //     Console.WriteLine("Address Details for the selected city not found...");
        // }
        
    }
}
