# Getting Started

1. Update the following variables in config.xml(you need copy the config.xml into the same folder where the exe file locates, like ./bin/Debug):
	* **API_URL** (The API URL you want to use, like https://api.nexiopaysandbox.com)
    * **USERNAME** (Your [dashboard.transactionplatform.com](https://dashboard.transactionplatform.com) username)
    * **PASSWORD** (Your [dashboard.transactionplatform.com](https://dashboard.transactionplatform.com) password)
	* **TOKENEX_TOKEN** (add description here)
	* **MERCHANT_ID** (Your Merchant Id)
	* **GATEWAY_NAME** (The gate way name you want to do transaction with, like usaepay)

2. Get public key from Complete Merchant Solution, save it as nexiopub.key file and put it in the same folder where the exe file locates, like ./bin/Debug.

# Build and run application
1. Build application.
   Choose 'Build Solution' or 'Rebuild Solution' in Build Menu of Microsoft Visual Studio

2. Run application from Microsoft Visual Studio directly.
   Choose 'Start Debugging' in Debug menu of Microsoft Visual Studio, or choose 'Start' in tool bar of Microsoft Visual Studio.

3. Run build exe file.
   Build the appliation as '1. Build Application' mentions, then find and run 'NexioPaySample.exe' in ./bin/debug or ./bin/release folder.

# Sample: Client Side Token
1. Run application, choose 'Client Side Token' tab.
2. Click 'Client Side Token' button, the result will display in 'Response Data' text box on right side. 
	* (Note that you need Get Nexio public key and save it as nexiopub.key file first otherwise you will not get success result.)
    
# Sample: Payment Service iFrame
	Run application, choose 'Payment Service iFrame' tab.
	* Get One Time Token
		Choose 'Get One Time Token' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Credit Card Transaction
		Choose 'Credit Card Transaction' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for Credit Card Transaction will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Alipay Transaction
		Choose 'Alipay Transaction' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for Alipay Transaction will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Save Card
		Choose 'Save Card' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for Save Card will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Save eCheck
		Choose 'Save eCheck' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for Save eCheck will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* eCheck Transaction
		Choose 'eCheck Transaction' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for eCheck Transaction will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.

# Sample: Payment Service
	Run application, choose 'Payment Service' tab.
	* Save Card
		Choose 'Save Card' radio button
		This transaction needs get Onetime-token first, so the body of 'Get One Time Token' POST data will display in 'Post Data' text box.
		The URL for Save Card will not display, you can find it in source code. 
		Click 'Send Command' button, result will display in 'Response Data' text box.
		A token record will be added into 'Token List' if transaction success.
	* Card Transaction
		Choose 'Card Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
		A transaction record will be added into 'Local Transaction List' if transaction succeess. 
	* Void Transaction
		This transaction need choose one transaction in 'Local Transaction List'.
		Choose 'Void Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Refund Transaction
		This transaction need choose one transaction in 'Local Transaction List'.
		Choose 'Refund Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Capture Transaction
		This transaction need choose one transaction in 'Local Transaction List'.
		Choose 'Capture Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* eCheck Transaction
		Choose 'eCheck Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
		A transaction record will be added into 'Local Transaction List' if transaction succeess. 
	* Delete Token
		This transaction need 'Token List' is not empty. It will delete all tokens in the 'Token List'
		Choose 'Delete Token' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.

# Sample: Transaction Service
	Run application, choose 'Transaction Service' tab.
	* Transaction (Using Transaction Id)
		This transaction need choose one transaction in 'Local Transaction List'.
		Choose 'Transaction (Using Transaction Id)' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Transaction
		This transaction need choose one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Transaction' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Matching Transaction For FDR Chargeback
		Choose 'Matching Transaction For FDR Chargeback' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Transaction Count
		Choose 'Transaction Count' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Daily Transaction Summary
		Choose 'Daily Transaction Summary' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Refund Transaction
		This transaction need choose one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Refund Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Transaction Total
		Choose 'Transaction Total' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Payment Types
		Choose 'Payment Types' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Bulk Void
		This transaction need choose at least one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Bulk Void' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Search Transaction
		Choose 'Search Transaction' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Bulk Capture
		This transaction need choose at least one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Bulk Capture' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Transactions
		Choose 'Transactions' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.
		All records in response will be added into 'Nexio Transaction List'.
	* Capture Transaction
		This transaction need choose one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Capture Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Void Transaction
		This transaction need choose one transaction in 'Nexio Transaction List', it require run 'Transactions' in 'Transaction Service' tab first.
		Choose 'Void Transaction' radio button, the url will display in 'URL' text box, the body of POST will display in 'Post Data' text box
		Click 'Send Command' button, result will display in 'Response Data' text box.
	* Transaction Summary
		Choose 'Transaction Summary' radio button, the url will display in 'URL' text box.
		Click 'Send Command' button, result will display in 'Response Data' text box.