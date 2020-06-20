using System;

namespace Ejercicio_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine(" Ingrese m");
            m = Convert.ToInt16(Console.ReadLine());
   
            Console.WriteLine(" Ingrese m");
            n = Convert.ToInt16(Console.ReadLine());

            int [] vecA ={0,2,4,9};
            int [] vecB = {1,2,3,5,9};


   }
   
                  private static int [] Distintos (int [] vecA, int [] vecB, int cantRest ){
                    int i = 0,j=0,k=0;
                    int [] vec = new int [vecA.Length + vecB.Length];
                      while(i< vecA.Length && j<vecB.Length){
                          if(vecA[i] == vecB[j]){
                              i++;
                              j++;

                          }
                          else{
                            if(vecA[i] < vecB[j]){
                            vec[k] = vecA[i];
                            i++;
                            k++;
                          }else {
                              vec[k] = vecB[j];
                              j++;
                              k++;
                          }
                        }
                          
                      } while(i < vecA.Length){
                          vec[k] = vecA[i];
                          k++;
                          i++;
                      }
                      while(i <vecB.Length){
                          vec[k] = vecB[j];
                          k++;
                          j++;
                      }

                      return vec;
         }



private static void Imprimir(int [] vector){

    }

  }
}
