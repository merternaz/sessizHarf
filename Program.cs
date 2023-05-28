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
                foreach(var harf in kelime){

                     /*if(!sesli.Contains(harf.ToString())){
                        counter++;
                        if(counter>1){
                            silent=true;
                            
                        }

                    }else{
                        counter=0;
                        silent=false;
                    }*/
                    if(counter>0){
                        if(!sesli.Contains(kelime[counter].ToString())&&!sesli.Contains(kelime[counter-1].ToString())){
                        // silent=true;
                        Console.WriteLine(kelime+"/"+kelime[counter-1].ToString()+kelime[counter].ToString());
                        }else{
                            silent=true;
                        }

                     /*   Console.Write(" "+kelime[counter].ToString());
                        
                        Console.Write(" "+sesli.Contains(kelime[counter].ToString()));
                        Console.WriteLine(" ");*/
                    }
                    
                    counter++;
                    
                }

                Console.Write(silent);
                Console.Write(" ");
            }
        }
    }
}