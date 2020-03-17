# Gateway-with-Ocelot
.Net Core Microservices with Ocelot Gateway

# Installation
####1- Set your ip-port configuration
	#####Set your port and ip configuration at Program.cs on each service as shown below
	#####webBuilder.UseUrls("http://YOUR IP:YOUR PORT");
	#####IP can be localhost or local network IP
####2- Set your ocelot.json
	#####In the gateway directory you will see a ocelot.json file
	#####Open it and set the service path
	#####Set service's host and port
	#####Check BaseUrl (It should be gateway url)
####3- Run the services
	#####-Open terminal and cd identityservice 
	#####-Type dotnet restore
	#####-Type dotnet run
	#####--Same 3 steps for the customerservice
	#####--Same 3 steps for the gateway


##Go to http://YOURURL:YOURPORT/customer-service/customer

					## SEE THE MAGIC ##
	