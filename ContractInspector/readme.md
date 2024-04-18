# ContractInspector

Using this tool you can:

1. Connect to the API provided by a running Interactive Brokers (IBKR) Trader 
   Workstation (TWS) or Gateway.
   
2. Enter a partial or complete contract specification.

3. Initiate a reqContractDetails() API call using this contract specification.
   
4. Examine the returned contract details in a data grid.

5. Select one or more contracts from the grid and initiate reqMktData() API 
   calls for each selected contract: the resulting data streams are displayed 
   in another grid. Optionally you can request snapshot data rather than full 
   market data.
   
6. Select a single contract from the contracts grid and initiate a reqMktDepth()
   API call. The market depth data is displayed in real-time in separate grids
   for bids and asks.

To install Contract Inspector, click [here](https://www.tradewright.com/contractinspector/ContractInspector.application).
This will install Contract Inspector as a 'ClickOnce' self-updating application
that will check for updates each time you start it, and ask you whether you want
to update it if any are found.

Note that some Windows users experience a problem where the install link just
downloads a page of XML, and the program is not installed. This began to happen
when the Chrome-based version of the Edge browser was introduced, though other
browsers are also affected. This was reported to Microsoft, but they have been
unable to throw any light on it. There are various settings, which are supposed
to govern the handling of the XML file, but they don't seem to work correctly
on some systems. The problem also affects some other Click-Once apps, so it's not
specific to the Contract Inspector.

The workaround is to right-click in the page of xml, select 'Save as', and save it
somewhere suitable (Downloads will do fine). Then go to the folder you saved it in
with File Explorer and double-click on the .application file. It should now run the
tool that handles these files and proceed with the installation.

Alternatively you can clone the repository to your computer and build it using 
Visual Studio with the ContractInspector.sln solution file in the ContractInspector
folder. Then run the ContractInspector.exe file.
