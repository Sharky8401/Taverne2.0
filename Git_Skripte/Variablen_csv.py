import os,re,csv
directory_path = os.getcwd()
PATH=f'{directory_path}/Dokumentation/Variablen'

file=open(f'{PATH}/Variablen├╝bersicht.txt','r')
data=file.read().split('\n')[1:-1]
structured_variables=[]
for line in data:
    line = re.sub('\t+','\t',line)
    structured_variables.append(line.split('\t'))
details=structured_variables[0]
rows=structured_variables[1:]

with open(f'{PATH}/Variablen├╝bersicht.csv', 'w') as file:
    write=csv.writer(file)
    write.writerow(details)
    write.writerows(rows)
