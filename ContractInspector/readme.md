#ContractInspector

Using this tool you can:

1. Connect to the API provided by a running Interactive Brokers (IBKR) Trader 
   Workstation (TWS) or Gateway.
2. Enter a partial or complete contract specification.
3. Initiate a reqContractDeatils() API call using this contract specification.
4. Examine the returned contract details in a data grid.
5. Select one or more contracts from the grid and initiate reqMktData() API 
   calls for each selected contract: the resulting data streams are displayed 
   in another grid.
6. Select a single contract from the contracts grid and initiate a reqMktDepth()
   API call. The market depth data is displayed in real-time in separate grids
   for bids and asks.

To install, simply download the relevant .zip file from the [Releases](Releases)
section and extract the files to a folder of your choice. Alternatively clone the
repository to your computer and build it using Visual Studio 15 or Visual Studio 17
from the ContractInspector.sln solution file in the ContractInspector folder.

To run, start the ContractInspector.exe file.
