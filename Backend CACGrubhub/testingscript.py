from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time

chrome_options = Options()
chrome_options.add_argument('--no-sandbox')
chrome_options.add_argument('--disable-dev-shm-usage')

driver = webdriver.Chrome(options=chrome_options)

driver.get("https://www.grubhub.com/restaurant/slurpin-ramen-bar-3500-w-8th-st-los-angeles/549399")

from selenium.webdriver.common.by import By
from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.common.exceptions import TimeoutException
#google_text = driver.find_element(By.CLASS_NAME, "c-body").text
#x = driver.find_element(By.xpath('//*[@id="menu-header"]/div/div[2]/div[1]/h1)')).text
#y = '//*[@id="menu-header"]/div/div[2]/div[1]/h1'
#y2 = '//*[@id="backdrop"]/span/div/dialog/span/span/span/span/form/div/div/header/div/h3'
#element = driver.find_element(By.XPATH, '//*[@id="goToAbout"]')
#driver.execute_script("arguments[0].click();", element)
#element = driver.find_element(By.XPATH, '//*[@id="navSection-categories"]')
#print(element)
#ids = driver.find_elements(By.XPATH, '//*[@id]')
#for li in ids:
#  print(li.get_attribute('impressionid'))
LocationXPATH = '//*[@id="Item3511856000"]/div'

driver.implicitly_wait(3)
while True:
  try:
    print("here")
    element = driver.find_element(By.XPATH, LocationXPATH)
  except:
    driver.implicitly_wait(1)
    driver.execute_script("window.scrollTo(0, window.scrollY + 200)")
    print("down one")
  else:
    print("works")
    driver.execute_script("arguments[0].click();", element)
    break
driver.implicitly_wait(10)
element = driver.find_element(By.XPATH,'//*[@id="backdrop"]/span/div/dialog/span/span/span/span/form/div/div/section[1]/p').text
print(element)



#x = driver.find_element(By.XPATH, y).text
#print(x)