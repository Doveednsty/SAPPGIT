'''
Финальный скрипт к приложению SApp
'''



import requests
import os
import apimoex
import pandas as pd
import time


 

request_url_name = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.meta=off&iss.only=securities&securities.columns=SECID,SECNAME')
arguments_name = {'securities.columns': ('SECID,'
                                         'SECNAME')}
request_url_price = ('http://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.dp=comma&iss.meta=off&iss.only=securities&securities.columns=SECID,PREVADMITTEDQUOTE')
arguments_price = {'securities.columns': ('SECID,'
                                          'PREVADMITTEDQUOTE,')}

pd.set_option('display.max_columns', None)
pd.set_option('display.max_rows', None)

while(True):
    with requests.Session() as session:
        iss = apimoex.ISSClient(session, request_url_name, arguments_name)
        data = iss.get()
        df_name = pd.DataFrame(data['securities'])
        df_name.set_index('SECID', inplace=False)



        iss = apimoex.ISSClient(session, request_url_price, arguments_price)
        data = iss.get()
        df1 = pd.DataFrame(data['securities'])
        df1.set_index('SECID', inplace=False)
        Table = pd.concat((df_name, df1), axis = 1)
        
        print(Table)
        Table.to_csv('Table.csv', index = False, header = False)
        time.sleep(1000)
        del(Table)
        os.system('CLS')








