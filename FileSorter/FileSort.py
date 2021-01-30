import os
import re
import shutil

DirTo = []
DirFrom = []
with open(os.path.dirname(os.path.abspath(__file__))+"\\log", 'w') as log:
  try:
   with open(os.path.dirname(os.path.abspath(__file__))+'\\main.cfg','r') as cfg:
    switch = ''
    for line in cfg:
        if switch == 'DirTo' and 'Path=' in line:
            pr = []
            line = line.replace('\n','')
            if line[-1] != '/':
                 line+='/'
            pr.append(line[5:])
        if switch == 'DirTo' and 'Reg=' in line:
            pr.append(line[4:].replace('\n',''))
            DirTo.append(pr)
        if switch == 'DirFrom':
            line = line.replace('\n','')
            if line[-1] != '/':
                 line+='/'
            DirFrom.append(line)

        if '[DirTo]' in line:
            switch = 'DirTo'
        if '[DirFrom]' in line:
            switch = 'DirFrom'
  except Exception as e:
       log.write("Что-то с конфигом...\n"+str(e)+'\n')

  try:
   for dirF in DirFrom:
        files = os.listdir(dirF)
        log.write(str(files)+'\n')
        for file in files:
            for dir in DirTo:
                 if re.match(dir[1],file):
                    try:
                        log.write('from: '+dirF+file+'\n')
                        log.write('to: '+dir[0]+file+'\n')
                        shutil.move(dirF+file,dir[0]+file)
                    except:
                        log.write('Что-то с файлом не так. \nВозможно:\n Пересечение правил\n Ошибка в конфиге')
  except Exception as e:
      log.write("Что-то с "+str(DirFrom)+'\n'+str(e)+'\n')