'''
Финальный скрипт к приложению SApp


Внесение правок PREVADMITTEDQUOTE
'''



import requests
import os
import apimoex
import pandas as pd
import time




REQUEST_URL_NAME = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.meta=off&iss.only=securities&securities.columns=SECID,SECNAME')
arguments_name = {'securities.columns': ('SECID,'
                                         'SECNAME')}
REQUEST_URL_PRICE = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.dp=comma&iss.meta=off&iss.only=securities&securities.columns=SECID,PREVADMITTEDQUOTE')
ARGUMENTS_PRICE = {'securities.columns': ('SECID,'
                                          'PREVADMITTEDQUOTE,')}

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
        Table = pd.concat((df_name, df1), axis = 1)
        Table.to_csv('Table.csv', index = False, header = False)
        #print(Table)
        time.sleep(900)
        del(Table)
        os.system('CLS')








