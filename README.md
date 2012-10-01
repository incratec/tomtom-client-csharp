gisgraphy-client
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

2. instantiate the GisgraphyClient
```c#
TomTomClient gc = new TomTomClient("YOUR API KEY");
```
You can obtain your API key at TomTom’s Map Toolkit API website.

3. geocode the address
```c#
var momaLocations = gc.CodeAddress(moma);
```
You will receive a list of addresses with latitude and longitue, along with additional data provided by TomTom.

See Program.cs for a working samples.

license
-------
Licensed under GPL v3 or later (refer to <a href="LICENSE">LICENSE</a> for the ful license text and more information).
Please credit https://www.geocoderpro.com e.g. using a link from your website.

Help and commercial usage
----------------
Please contact us at https://www.geocoderpro.com/en/support/ if you need help or are interested in commercial usage of this code.
