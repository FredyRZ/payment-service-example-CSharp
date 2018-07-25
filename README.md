# API: Getting Started

## Obtain JSON Web Token (JWT)
1. Update the following variables in config.xml(you need copy the config.xml into the same folder where the exe file locates, like ./bin/Debug):
	* **API_URL** (The API URL you want to use, like https://api.nexiopaysandbox.com)
    * **USERNAME** (Your [dashboard.transactionplatform.com](https://dashboard.transactionplatform.com) username)
    * **PASSWORD** (Your [dashboard.transactionplatform.com](https://dashboard.transactionplatform.com) password)
	* **TOKENEX_TOKEN** (add description here)
	* **MERCHANT_ID** (Your Merchant Id)
	* **GATEWAY_NAME** (The gate way name you want to do transaction with, like usaepay)

6. Run Get Json Web Token (JWT):

    > Run applicatioin and click Get JWT button. 

    * This script will print your JSON Web Token to the console. This token will be used in the next step to run a transaction.
    * (Note that this token expires after one hour.)

# API: Run Transaction
1. Click Run Transaction button.
	* (Note that you need Get JWT first otherwise you will not get success result.)
    
# API: Refund/Void/Capture
1. Click Void Transaction/Refund Transaction/Capture transaction Button. 
