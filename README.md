# ImPlantStatements

We are a world class organization that provides best software to design implants.
Our software has 2 supreme features that will be charged on usage basis.

The features are 
	1) Design Implant
	2) Print Implant

The above mentioned features are charged with different amounts, based on the Tier it belongs to.
For eg.
	Design Implant
		Tier 1 - Tier 5   => 29.99 EUR/per usage
		Tier 6 - Tier 10 => 34.99 EUR/per usage
	Print Implant
		Tier 1 - Tier 25  => 49.99 EUR/per usage
		Tier 26- Tier 30 => 59.99 EUR/per usage

Problem Statement: 
The billing service that manages the billing gets the quantity of usages for the above feature.
Based on the quantity of usage received, our service should be able to calculate the amount to be billed.
Create a function that takes the feature name and quantity used to calculate the final amount to be billed.
Handle the edge case scenarios if requried and your function should be as dynamic as possible.
Sample Input can have additional items if needed.

Sample Input:
{
	Usages: [
			 {
				 featureName: DesignImplant
				 quantityUsed: 8
			 },
			 {
				 featureName: PrintImplant
				 quantityUsed: 18
			 }
		 ]
}

Sample Output:
{
	BillableAmount: 1154.74
}

Breakdown of the result
	1) Bill for Design Implant = (5 * 29.99) = 149.95 + (3 * 34.99) = 104.97
	2) Bill for Print Implant =  18 * 49.99 = 899.82 
	Total Bill = (149.95 + 104.97 + 899.82) = 1,154.74
