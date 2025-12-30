#ifndef __pcquote_h
#define __pcquote_h

#ifdef __cplusplus
extern "C" {
#endif

/*
	-----------------------------------------
		 COSTANTI LIBRERIA LIBPCQUOTE
	-----------------------------------------
*/

#define	MAX_SIGLA_MSG_SQUO		6		/*numero max caratteri sigla*/
#define	MAX_STRINGA_MSG_SQUO	80		/*numero max caratteri messaggio*/
#define	MAX_STRINGA_PROG_SQUO	256		/*numero max caratteri programma*/
#define	MAX_STRINGA_DSTN_SQUO	256		/*numero max caratteri distinta*/

/*
	---------------------------------------------
	 DICHIARAZIONE DELLE FUNZIONI DELLA LIBRERIA
	---------------------------------------------
*/

int				openQuoChannel(char *nomemacc);
void			closeQuoChannel(void);
int				setOpenQuoTenta(int rtenta);
int				sendQuoMessage(char *sigla,char *mess);
int				sendQuoGetFlagsStato(int *fdstn,int *fmaut,int *fstar);
int				sendQuoStartProg(void);
int				sendQuoSelProg(char *nomep,char *parap);
int				sendQuoGetProg(char *prgsel);
int				sendQuoStartDstn(void);
int				sendQuoRowDstn(char *strriga);
int				sendQuoProgDstn(char *nomep,char *parap);
int				sendQuoGetProgDstn(char *prgrig);
int				sendQuoDelRowDstn(int riga);
int				sendQuoSetPosDstn(int riga);
int				sendQuoGetPosDstn(int *rigc);
int				sendQuoLoadDstn(char *nomef);
int				sendQuoSaveDstn(char *nomef);
int				sendQuoGetInfDstn(char *nomed,int *rigd);
int				sendQuoSetQntaCont(int riga,int qnta,int cont);
int				sendQuoGetQntaCont(int riga,int *dqta,int *dcnt);
int				sendQuoGetRowDstn(int riga, char *dstr);
int				sendQuoGetRowExeDstn(int *dord, char *dstr);

int _stdcall	openQuoChannelVb(char *nomemacc);
int _stdcall	closeQuoChannelVb(void);
int _stdcall	setOpenQuoTentaVb(int rtenta);
int _stdcall	sendQuoMessageVb(char *sigla,char *mess);
int _stdcall	sendQuoGetFlagsStatoVb(int *fdstn,int *fmaut,int *fstar);
int _stdcall	sendQuoStartProgVb(void);
int _stdcall	sendQuoSelProgVb(char *nomep,char *parap);
int _stdcall	sendQuoGetProgVb(char *prgsel);
int _stdcall	sendQuoStartDstnVb(void);
int _stdcall	sendQuoRowDstnVb(char *strriga);
int _stdcall	sendQuoProgDstnVb(char *nomep,char *parap);
int _stdcall	sendQuoGetProgDstnVb(char *prgrig);
int _stdcall	sendQuoDelRowDstnVb(int riga);
int _stdcall	sendQuoSetPosDstnVb(int riga);
int _stdcall	sendQuoGetPosDstnVb(int *rigc);
int _stdcall	sendQuoLoadDstnVb(char *nomef);
int _stdcall	sendQuoSaveDstnVb(char *nomef);
int _stdcall	sendQuoGetInfDstnVb(char *nomed,int *rigd);
int _stdcall	sendQuoSetQntaContVb(int riga,int qnta,int cont);
int _stdcall	sendQuoGetQntaContVb(int riga,int *dqta,int *dcnt);
int _stdcall	sendQuoGetRowDstnVb(int riga, char *dstr);
int _stdcall	sendQuoGetRowExeDstnVb(int *dord, char *dstr);

#ifdef __cplusplus
}
#endif

#endif __pcquote_h