//Yildiz Yapma Programi

#include <stdio.h>

main()
{
	int Buyukluk,i,j,k;
	printf("Buyuklugu giriniz :");
	scanf("%d",&Buyukluk);		
	
	for(i=0;i<Buyukluk;i++)
	{		
		for(j=i;j<Buyukluk;j++)
		{	
			if(j==Buyukluk-1)
			{
				printf("/");
			}	
			else
			{
				printf(" ");
			}
		}					
		
		
		for(j=0;j<=Buyukluk;j++)
		{			
			for(k=i;k<=Buyukluk;k++)
			{
				printf(" ");	
			}
			
			printf("\\");
		}
		
		/*
		for(j=Buyukluk;j>Buyukluk;j--)
		{	
			if()
			{
				printf("/");
			}	
			else
			{
				printf(" ");
			}
		}						
		*/
		
		
		printf("\n");
			
	}
	
	
	
	
}

