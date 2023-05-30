using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz :");
            string s=Console.ReadLine();
            string[] cumle=s.Split();
            string[] sesli={"a","e","ı","i","o","ö","u","ü","A","B","I","İ","O","Ö","U","Ü"};

            foreach(var kelime in cumle){

                int counter=0;
                bool silent=false;
             

                for(int i=0;i<kelime.Length;i++){
                    if(i>0){
                        if(!sesli.Contains(kelime[i].ToString())&&!sesli.Contains(kelime[i-1].ToString())){
                        silent=true;
                        }
                    }
                    
                }

                Console.Write(silent);
                Console.Write(" ");
            }
        }
    }
}