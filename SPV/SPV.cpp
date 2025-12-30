// SPV.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <string.h>
#include <stdio.h>
#include <C:\Users\ca01114\source\repos\SPV\pcquote.h>

int main()
{
	char connection_string[100] = "192.168.168.31";
	char* _xnc = connection_string;

	char workilist_string[100] = "PROG1.bSolid1";
	char* row_str = workilist_string;

	char message1_string[100] = "PC1";
	char* message1 = message1_string;

	char message2_string[100] = "PC CONNECTED";
	char* message2 = message2_string;

	int val_ret;
	int val_ret1;

	val_ret = openQuoChannel(_xnc);
	if (val_ret != 0)
	{
		printf("XNC Connection Error = % d", val_ret);
	}
	else
	{
		val_ret = sendQuoMessage(message1, message2);
		val_ret1 = sendQuoRowDstn(row_str);
		if (val_ret1 != 0)
			printf("Worklist Line Send Error=%d", val_ret1);
		else
			printf("Worklist Line Sent=%s", row_str);
	}

}
