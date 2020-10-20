from bs4 import BeautifulSoup
from selenium import webdriver
from selenium.webdriver.support.ui import Select
import time
import requests
import pyodbc
import re


def get_data():
	driver = webdriver.Firefox()
	driver.get('http://arsiv.mackolik.com/Genis-Iddaa-Programi')
	
	select = Select(driver.find_element_by_id('dayId'))
	select.select_by_value('-1')
	time.sleep(3)
	driver.find_element_by_id('justNotPlayed').click()
	time.sleep(4)

	driver.get('http://arsiv.mackolik.com/AjaxHandlers/ProgramDataHandler.ashx?type=6&sortValue=DATE&day=-1&sort=-1&sortDir=1&groupId=-1&np=0&sport=1')
	time.sleep(3)
	html = driver.page_source
	soup = BeautifulSoup(html, 'html.parser')
	body = soup.find('body')
	dosya = open('data.txt', 'w') 
	dosya.write(str(body))

	with open('data.txt', 'r') as file:
		data=file.read().replace("/n","")
	driver.quit()
	matches = re.findall(r"\[.*?\]",data)
	matches=matches[1:]


	conn = pyodbc.connect('Driver={SQL Server Native Client 11.0};Server=MAU-MÜHENDIS23;Database=MacOranlari;Trusted_Connection=yes;')
	cursor = conn.cursor()

	for match in matches:

		rate = match.split(",")    #maç oranları ayrımı
		date = rate[7].replace("'","")             #tarih
		hour = rate[6].replace("'","")        
		league = rate[26].replace("'","")          #lig
		home = rate[1].replace("'","")             #evsahibi
		away = rate[3].replace("'","")             #misafir
		iyhome = rate[11].replace("'","")          #ilkyarı ev sahibi sonuç
		iyaway = rate[12].replace("'","")          #ilkyarı misafir sonuç
		mshome = rate[8].replace("'","")	       #maçsonu ev sahibi sonuç
		msaway = rate[9].replace("'","")          #maçsonu misafir sonuç
		endmatch1 = rate[16].replace("'","") + "," + rate[17].replace("'","")        #maçsonu1
		endmatchx = rate[18].replace("'","") + "," + rate[19].replace("'","")        #maçsonux
		endmatch2 = rate[20].replace("'","") + "," + rate[21].replace("'","")       #maçsonu2
		firsthalf1 = rate[45].replace("'","") + "," + rate[46].replace("'","")       #ilkyarı1
		firsthalfx = rate[47].replace("'","") + "," + rate[48].replace("'","")       #ilkyarıx
		firsthalf2 = rate[49].replace("'","") + "," + rate[50] .replace("'","")      #ilkyarı2
		kgv = rate[57].replace("'","") + "," + rate[58].replace("'","")              #karşılıklı gol var
		kgy = rate[59].replace("'","") + "," + rate[60].replace("'","")              #karşılıklı gol yok
		doublechance1x = rate[22].replace("'","") + "," + rate[23].replace("'","")   #çifte şans 1/x
		doublechance12 = rate[24].replace("'","") + "," + rate[25].replace("'","")   #çifte şans 1/2
		doublechancex2 = rate[26].replace("'","") + "," + rate[27].replace("'","")   #çfte şans x/2
		iu15a = rate[62].replace("'","") + "," + rate[63].replace("'","")            #İY 1,5 gol alt
		iu15u = rate[64].replace("'","") + "," + rate[65].replace("'","")           #İY 1,5 gol üst
		au15a = rate[66].replace("'","") + "," + rate[67].replace("'","")            #AÜ 1,5 gol alt
		au15u = rate[68].replace("'","") + "," + rate[69].replace("'","")            #AÜ 1,5 gol üst
		au25a = rate[28].replace("'","") + "," + rate[29].replace("'","")            #AÜ 2,5 gol alt
		au25u = rate[30].replace("'","") + "," + rate[31].replace("'","")            #AÜ 2,5 gol üst
		au35a = rate[70].replace("'","") + "," + rate[71].replace("'","")           #AÜ 3,5 gol alt
		au35u = rate[72].replace("'","") + "," + rate[73].replace("'","")           #AÜ 3,5 gol üst
		tg01 = rate[37].replace("'","") + "," + rate[38].replace("'","")             #Toplam gol 0-1
		tg23 = rate[39].replace("'","") + "," + rate[40].replace("'","")             #Toplam gol 2-3
		tg46 = rate[41].replace("'","") + "," + rate[42].replace("'","")             #Toplam gol 4-6
		tg7 = rate[43].replace("'","")  + "," + rate[44].replace("'","")            #Toplam gol 7+  

		cnt=cursor.execute("Select Id from Mac_Oranları_Tablo where Tarih='"+date+"' and EvSahibi='"+home+"' and Misafir='"+away+"'")
		_Id=cnt.fetchone()
		
		if(re.search('[a-zA-Z]', tg01) is None):
			try:
				if(len(_Id)>0):
					
					cursor.execute("SET DATEFORMAT dmy UPDATE Mac_Oranları_Tablo SET IYEvSahibi='"+iyhome+"',IYMisafir='"+iyaway+"',MSEvsahibi='"+mshome+"',MSMisafir='"+msaway+"',MacSonucu1='"+endmatch1+"',MacSonucuX='"+endmatchx+"',MacSonucu2='"+endmatch2+"',IlkYari1='"+firsthalf1+"',IlkYariX='"+firsthalfx+"',IlkYari2='"+firsthalf2+"',KGVar='"+kgv+"',KGYok='"+kgy+"',CifteSans1X='"+doublechance1x+"',CifteSans12='"+doublechance12+"',CifteSansX2='"+doublechancex2+"',IY15A='"+iu15a+"',IY15U='"+iu15u+"',AU15A='"+au15a+"',AU15U='"+au15u+"',AU25A='"+au25a+"',AU25U='"+au25u+"',AU35A='"+au35a+"',AU35U='"+au35u+"',TG01='"+tg01+"',TG23='"+tg23+"',TG46='"+tg46+"',TG7='"+tg7+"'  WHERE Id='"+str(_Id[0])+"'")
				
			except Exception as e:
				
				cursor.execute('SET DATEFORMAT dmy INSERT INTO dbo.Mac_Oranları_Tablo(Tarih,Saat,Lig,EvSahibi,Misafir,IYEvSahibi,IYMisafir,MSEvsahibi,MSMisafir,MacSonucu1,MacSonucuX,MacSonucu2,IlkYari1,IlkYariX,IlkYari2,KGVar,KGYok,CifteSans1X,CifteSans12,CifteSansX2,IY15A,IY15U,AU15A,AU15U,AU25A,AU25U,AU35A,AU35U,TG01,TG23,TG46,TG7) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);',date,hour,league,home,away,iyhome,iyaway,mshome,msaway,endmatch1,endmatchx,endmatch2,firsthalf1,firsthalfx,firsthalf2,kgv,kgy,doublechance1x,doublechance12,doublechancex2,iu15a,iu15u,au15a,au15u,au25a,au25u,au35a,au35u,tg01,tg23,tg46,tg7)
				
		
		
		
		conn.commit()

	driver.quit()
if __name__ == '__main__':
	
	get_data()
