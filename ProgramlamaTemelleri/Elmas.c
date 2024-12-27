//Yildiz Yapma Programi

#include <stdio.h>

main()
{
	int Buyukluk,i,j;
	printf("Buyuklugu giriniz :");
	scanf("%d",&Buyukluk);
	
	for(i=1;i<=Buyukluk*2;i++)
	{	
		//printf("i:%d - j:%d \t",i,j);
		for(j=1;j<=Buyukluk*2;j++)
		{		
			if((j+i)-1==Buyukluk)
			{
				printf("/");
			}				
			else if(j>Buyukluk && j<=Buyukluk*2 )
			{	
				if(j-i==Buyukluk)
				{
					printf("\\");
				}
				else
				{
					if((i-1)-Buyukluk == Buyukluk*2-j && i>Buyukluk)
					{
						printf("/");
					}
					else 
					{
						printf(" ");	
					}
				}
			}
			else if(i>Buyukluk)
			{
				if(i-j==Buyukluk)
				{
					printf("\\");
				}
				else
				{
					printf(" ");
				}
			}
			else
			{
				printf(" ");
			}
		}
		printf("\n");
	}
}

