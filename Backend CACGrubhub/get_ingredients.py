from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time

chrome_options = Options()
chrome_options.add_argument('--no-sandbox')
chrome_options.add_argument('--disable-dev-shm-usage')

driver = webdriver.Chrome(options=chrome_options)

driver.get(
    "https://www.grubhub.com/restaurant/slurpin-ramen-bar-3500-w-8th-st-los-angeles/549399"
)

from selenium.webdriver.common.by import By
from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.common.exceptions import TimeoutException

LocationXPATH = '//*[@id="menuItem-3511856000"]/div[1]/div[1]/span'
#//*[@id="menuItem-3511856049"]/div[1]/div[1]/span

driver.implicitly_wait(3)
driver.execute_script("window.scrollTo(0, window.scrollY + 600)")
driver.implicitly_wait(3)
driver.execute_script("window.scrollTo(0, window.scrollY + 300)")
driver.implicitly_wait(1)
#ids = driver.find_elements(By.CLASS_NAME, 'menuItemRegular-name h6 u-text-ellipsis')
ids = driver.find_elements(By.XPATH, '//*[@class]')
for ii in ids:
      if "menuItemRegular-name h6 u-text-ellipsis" in ii.get_attribute('class'):
        print(ii.get_attribute('class'))
        print(ii.text)
      #print(ii.get_attribute('id').name)
print("done")

#x = driver.find_element(By.XPATH, y).text
#print(x)
