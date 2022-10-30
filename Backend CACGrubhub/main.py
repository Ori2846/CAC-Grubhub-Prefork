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

#LocationXPATH = '//*[@id="menuItem-3511856000"]/div[1]/div[1]/span'
#//*[@id="menuItem-3511856049"]/div[1]/div[1]/span

driver.implicitly_wait(3)
#ids = driver.find_elements(By.CLASS_NAME, 'menuItemRegular-name h6 u-text-ellipsis')
ids = driver.find_elements(By.XPATH, '//*[@id]')
for ii in ids:
      if "goToReviews" in ii.get_attribute('id'):
        print(ii.get_attribute('class'))
        ii.click()
      #print(ii.get_attribute('id').name)
names = driver.find_elements(By.XPATH, '//*[@data-testid]')
review_fromname = driver.find_elements(By.XPATH, '//*[@class]')
for li in names:
      if "review-reviewer-name" in li.get_attribute('data-testid'):
        print(li.get_attribute('data-testid'))
        print(li.text)
for lli in review_fromname:
      if "body u-stack-x-3 u-stack-y-3" in lli.get_attribute('class'):
        print(lli.get_attribute('class'))
        print(lli.text)
print("done")

#x = driver.find_element(By.XPATH, y).text
#print(x)
