using System;
namespace InterseccionMatrices
{
  public class Matrices
  {
  	public static void Main(string[] args)
	{
		int x = 5;
		int y = 5;
		int i = 0;
		int j = 0;
		int[,] matrizA = new int[x,y];
		int[,] matrizB = new int[x,y];
		int[,] matrizC = new int[x,y];
		
		
		
		Random randomA = new Random();
		for(i = 0; i< x;i++){
			for(j = 0; j<y; j++){
    			matrizA[i,j] = randomA.Next(0,2);
			}
		}
		
		Random randomB = new Random();
		
		for(i = 0; i< x;i++){
			for(j = 0; j<y; j++){
    			matrizB[i,j] = randomB.Next(0,2);
			}
		}


		for(i = 0; i< x; i++){
			string line = " | ";
			for(j = 0; j<y; j++){
    			line += matrizA[i,j]+" | ";
			}
			Console.WriteLine(line);
		}
		Console.WriteLine("\n\t\t+ \n");
		
		for(i = 0; i< x; i++){
			string line = " | ";
			for(j = 0; j<y; j++){
    			line += matrizB[i,j]+" | ";
			}
			Console.WriteLine(line);
		}
		for(i = 0; i< x;i++){
			for(j = 0; j<y; j++){
				if(matrizA[i,j] == 1 && matrizB[i,j]==1){
					matrizC[i,j] = 1;
				}else{
					matrizC[i,j] = 0;	
				}
			}
		}
		
		Console.WriteLine("\n \t	= \n");
		
		for(i = 0; i< x; i++){
			string line = " | ";
			for(j = 0; j<y; j++){
    			line += matrizC[i,j]+" | ";
			}
			Console.WriteLine(line);
		}
    }
  }
}