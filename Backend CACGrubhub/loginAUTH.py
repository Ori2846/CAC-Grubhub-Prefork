from flask import Flask, render_template
from replit import db
app = Flask(__name__)

@app.route('/')
def index():
	return '12'
@app.route('/user/<string:name>', methods=['GET', 'POST'])
def user_view(name,password):
	print("yes")
	print(name)
	return name
@app.route('/login$username=<username>$password=<password>', methods=['GET', 'POST'])
def login(username, password):
	print(username)
	ArrayLocation = 0
	for i in db['username']:
		if username == db['username'][ArrayLocation]:
			if password == db['password'][ArrayLocation]:
				return "Logged in as "+ username
			else:
				return "Wrong password"
		else:
			ArrayLocation = ArrayLocation + 1
	
	#db["username"].append(username)
	#db["password"].append(password)
	#return f"Username: {username}\nPassword: {password}"
	return "User does not exist"

@app.route('/signup$username=<username>$password=<password>', methods=['GET', 'POST'])
def signup(username, password):
	print(username)
	for i in db['username']:
		print(i)
		if username in db['username']:
			return username + " is already taken"
		else:
			db["username"].append(username)
			db["password"].append(password)
			return f"Username: {username}\nPassword: {password}"


print(db['username'][0])
if __name__ == '__main__':
	app.run(host='0.0.0.0', port=80)