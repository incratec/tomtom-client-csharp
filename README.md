tomtom-client
================

C# client for TomTom Geocoding API

files
-----
* TomTomClient.cs: encapsulates the communication with TomTom geocoding server
* Address.cs: encapsulates an address, used as input and output for TomTomClient
* Program.cs: sample file showing the usage

usage
-----
1. create the source address 
```c#
Address moma = new Address();
moma.Street = "West 53 Street";
moma.Number = "11";
moma.ZIP = "10019";
moma.City = "New York";
moma.State = "NY";
moma.Country = "USA";
```

2. instantiate the TomTom geocoding client
```c#
TomTomClient gc = new TomTomClient("YOUR API KEY");
```
You can obtain your API key at TomTom's Map Toolkit API website.

3. geocode the address
```c#
var momaLocations = gc.CodeAddress(moma);
```
You will receive a list of addresses with latitude and longitue, along with additional data provided by TomTom.

See Program.cs for a working samples.

license
-------
Licensed under MIT license (refer to <a href="LICENSE">LICENSE</a> for the license text and more information).
Please credit http://www.geocoderpro.com e.g. using a link from your website.

help + support
--------------
Please contact us at https://www.geocoderpro.com/ if you need help.
