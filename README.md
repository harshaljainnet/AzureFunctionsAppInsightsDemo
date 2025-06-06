This is a functionapp
It has 2 functions i.e. Function-1 & Function-2

Function-1 is slow running function i.e. it has performance issues. I have added delay of 10 seconds in it
Function-2 simply throws an exception

So, basically, we can deploy this function app in azure and link azure app insights with it
Then, we can run function-1 & function-2 a few times

Finally, we can find this info i.e. slow running functions and also functions which throw an exception in app insights
