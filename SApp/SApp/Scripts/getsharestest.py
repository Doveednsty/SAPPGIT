import requests
import os
import apimoex
import pandas as pd
import time




# Securities
REQUEST_URL_NAME = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.meta=off&iss.only=securities&securities.columns=SECID,SECNAME')
arguments_name = {'securities.columns': ('SECID,'
                                         'SECNAME')}
REQUEST_URL_PRICE = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.dp=comma&iss.meta=off&iss.only=securities&securities.columns=SECID,PREVADMITTEDQUOTE')
ARGUMENTS_PRICE = {'securities.columns': ('SECID,'
                                          'PREVADMITTEDQUOTE,')}

# Marketdata
REQUEST_URL_MD = ('https://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.only=marketdata&iss.meta=on&iss.dp=comma&marketdata.columns=SECID,LAST')
ARGUMENTS_MD =  {'marketdata.columns': ('SECID,'
                                        'LAST')}


pd.set_option('display.max_columns', None)
pd.set_option('display.max_rows', None)

while(True):
    with requests.Session() as session:
        iss = apimoex.ISSClient(session, REQUEST_URL_NAME, arguments_name)
        data = iss.get()
        df_name = pd.DataFrame(data['securities'])
        df_name.set_index('SECID', inplace=False)



        iss = apimoex.ISSClient(session, REQUEST_URL_PRICE, ARGUMENTS_PRICE)
        data = iss.get()
        df1 = pd.DataFrame(data['securities'])
        df1.set_index('SECID', inplace=False)

        df1 = df1.drop(df1.columns[[0]], axis=1)



        iss = apimoex.ISSClient(session, REQUEST_URL_MD, ARGUMENTS_MD)
        data = iss.get()
        df2 = pd.DataFrame(data['marketdata'])
        df2.set_index('SECID', inplace=False)

        df2 = df2.drop(df2.columns[[0]], axis=1)
        


        
        
        Table = pd.concat((df_name, df1, df2), axis = 1)
        Table.to_csv('Table.csv', index = False, header = False)
        #print(Table)
        time.sleep(900)
        del(Table)
        os.system('CLS')














