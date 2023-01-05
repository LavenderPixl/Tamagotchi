using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Egg
    {
        public int ID { get; set; }
        public ConsoleColor Color { get; set; }
        public string? Name { get; set; }


          //          ■■■■
          //       ■■      ■■
          //     ■■          ■■
          //    ■■            ■■
          //   ■■              ■■
          //  ■■                ■■
          // ■■                  ■■
          //■■                    ■■
          //■■                    ■■
          //■■                    ■■
          // ■■                  ■■
          //  ■■                ■■
          //   ■■              ■■ 
          //     ■■          ■■
          //        ■■■■■■■■   
                  
        public string Egg1 =
        
            $$"""
                                                                 
                                ████████                                  
                              ██        ██                                
                            ██▒▒▒▒        ██                              
                          ██▒▒▒▒▒▒      ▒▒▒▒██                            
                          ██▒▒▒▒▒▒      ▒▒▒▒██                            
                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          
                        ██                ▒▒▒▒██                          
                      ██▒▒      ▒▒▒▒▒▒          ██                        
                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        
                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        
                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        
                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          
                        ██▒▒▒▒            ▒▒▒▒██                          
                          ██▒▒              ██                            
                            ████        ████                              
                                ████████                                  
                             

    """
        ;
        public string Egg2 =

            $$"""
                                                                    
                                   ████████                                  
                                 ██        ██                                
                               ██▒▒▒▒        ██                              
                             ██▒▒▒▒▒▒      ▒▒▒▒██                            
                             ██▒▒▒▒▒▒      ▒▒▒▒██                            
                           ██  ▒▒▒▒        ▒▒▒▒▒▒██                          
                           ██                ▒▒▒▒██                          
                         ██▒▒      ▒▒▒▒▒▒          ██                        
                         ██      ▒▒▒▒▒▒▒▒▒▒        ██                        
                         ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        
                         ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        
                           ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          
                           ██▒▒▒▒            ▒▒▒▒██                          
                             ██▒▒              ██                            
                               ████        ████                              
                                   ████████                                  
                                 
    """
        ;
        public string Egg3 =

            $$"""
                                                              
                             ████████                                  
                           ██        ██                                
                         ██▒▒▒▒        ██                              
                       ██▒▒▒▒▒▒      ▒▒▒▒██                            
                       ██▒▒▒▒▒▒      ▒▒▒▒██                            
                     ██  ▒▒▒▒        ▒▒▒▒▒▒██                          
                     ██                ▒▒▒▒██                          
                   ██▒▒      ▒▒▒▒▒▒          ██                        
                   ██      ▒▒▒▒▒▒▒▒▒▒        ██                        
                   ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        
                   ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        
                     ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          
                     ██▒▒▒▒            ▒▒▒▒██                          
                       ██▒▒              ██                            
                         ████        ████                              
                             ████████                                  
                             
         
    """
        ;





        public string Junior =
            $$"""









            """;




    
        public Egg(ConsoleColor color, string name) 
        {
            Color = color;
            Name = name;
        }


        public void Shake()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(Egg1);
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine(Egg2);
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(Egg1);
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(Egg3);
                Thread.Sleep(200);
                Console.Clear();

            }
            Console.WriteLine(Egg1);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
