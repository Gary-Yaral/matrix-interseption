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
		int m = 0;
		int counterX = 0;
		int counterY = 0;
		string lineY;
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

		lineY =" | ";
		for(i = 0; i< x; i++){
			string line = " | ";
			counterX = 0;
			counterY = 0;
			for(j = 0; j<y; j++){
    			line += matrizA[i,j]+" | ";
    			if(matrizA[i,j]==0){
    				counterX++;
    			}
    			
    			if(matrizA[j,i]==0){
    				counterY++;
    			}
			}
			lineY += counterY+" | ";
			Console.WriteLine(line+counterX+" |");
		}
		Console.WriteLine(lineY+"  |");
		Console.WriteLine("\n\t\t+ \n");
		
		lineY = " | ";
		for(i = 0; i< x; i++){
			string line = " | ";
			counterX = 0;
			counterY = 0;
			
			for(j = 0; j<y; j++){
    			line += matrizB[i,j]+" | ";
    			if(matrizB[i,j]==0){
    				counterX++;
    			}
				if(matrizB[j,i]==0){
    				counterY++;
    			}
			}
			lineY += counterY+" | ";
			Console.WriteLine(line+counterX+" |");
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
		Console.WriteLine(lineY+"  |");
		Console.WriteLine("\n \t	= \n");
		lineY = " | ";
		for(i = 0; i< x; i++){
			string line = " | ";
			counterX = 0;
			counterY = 0;
			for(j = 0; j<y; j++){
    			line += matrizC[i,j]+" | ";
    			if(matrizC[i,j]==0){
    				counterX++;
    			}
    			if(matrizC[j,i] == 0){
    				counterY++;
    			}
			}
			lineY += counterY+" | ";
			Console.WriteLine(line+counterX+" |");
		}
		Console.WriteLine(lineY);
    }
  }
}